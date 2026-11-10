// Decompiled with JetBrains decompiler
// Type: Terraria.RemoteClient
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.Net.Sockets;

#nullable disable
namespace Terraria;

public class RemoteClient
{
  public ISocket Socket;
  public int Id;
  public string Name = "Anonymous";
  public bool IsActive;
  public bool PendingTermination;
  public bool PendingTerminationApproved;
  public bool IsAnnouncementCompleted;
  public int State;
  public int TimeOutTimer;
  public string StatusText = "";
  public string StatusText2;
  public int StatusCount;
  public int StatusMax;
  public bool[,] TileSections = new bool[Main.maxTilesX / 200 + 1, Main.maxTilesY / 150 + 1];
  public uint[,] TileSectionsCheckTime = new uint[Main.maxTilesX / 200 + 1, Main.maxTilesY / 150 + 1];
  public bool CheckingSections;
  public byte[] ReadBuffer;
  public float SpamProjectile;
  public float SpamAddBlock;
  public float SpamDeleteBlock;
  public float SpamWater;
  public float SpamProjectileMax = 100f;
  public float SpamAddBlockMax = 100f;
  public float SpamDeleteBlockMax = 500f;
  public float SpamWaterMax = 50f;
  private volatile bool _isReading;

  public static event Action<int, Point> NetSectionActivated;

  public bool IsConnected() => this.Socket != null && this.Socket.IsConnected();

  public bool ReadBufferFull
  {
    get => NetMessage.buffer[this.Id].RemainingReadBufferLength < this.ReadBuffer.Length;
  }

  public void SpamUpdate()
  {
    if (!Netplay.SpamCheck)
    {
      this.SpamProjectile = 0.0f;
      this.SpamDeleteBlock = 0.0f;
      this.SpamAddBlock = 0.0f;
      this.SpamWater = 0.0f;
    }
    else
    {
      if ((double) this.SpamProjectile > (double) this.SpamProjectileMax)
        NetMessage.BootPlayer(this.Id, NetworkText.FromKey("Net.CheatingProjectileSpam"));
      if ((double) this.SpamAddBlock > (double) this.SpamAddBlockMax)
        NetMessage.BootPlayer(this.Id, NetworkText.FromKey("Net.CheatingTileSpam"));
      if ((double) this.SpamDeleteBlock > (double) this.SpamDeleteBlockMax)
        NetMessage.BootPlayer(this.Id, NetworkText.FromKey("Net.CheatingTileRemovalSpam"));
      if ((double) this.SpamWater > (double) this.SpamWaterMax)
        NetMessage.BootPlayer(this.Id, NetworkText.FromKey("Net.CheatingLiquidSpam"));
      this.SpamProjectile -= 0.4f;
      if ((double) this.SpamProjectile < 0.0)
        this.SpamProjectile = 0.0f;
      this.SpamAddBlock -= 0.3f;
      if ((double) this.SpamAddBlock < 0.0)
        this.SpamAddBlock = 0.0f;
      this.SpamDeleteBlock -= 5f;
      if ((double) this.SpamDeleteBlock < 0.0)
        this.SpamDeleteBlock = 0.0f;
      this.SpamWater -= 0.2f;
      if ((double) this.SpamWater >= 0.0)
        return;
      this.SpamWater = 0.0f;
    }
  }

  public void SpamClear()
  {
    this.SpamProjectile = 0.0f;
    this.SpamAddBlock = 0.0f;
    this.SpamDeleteBlock = 0.0f;
    this.SpamWater = 0.0f;
  }

  public static void CheckSection(int playerIndex, Vector2 position, int fluff = 1)
  {
    RemoteClient client = Netplay.Clients[playerIndex];
    if (client.CheckingSections)
      return;
    RemoteClient.CheckSection_ForClient(client, position, fluff);
    try
    {
      client.CheckingSections = true;
      for (int playerIndex1 = 0; playerIndex1 < (int) byte.MaxValue; ++playerIndex1)
      {
        Player player = Main.player[playerIndex1];
        if (player.active && player.spectating == playerIndex)
          RemoteClient.CheckSection(playerIndex1, position, fluff);
      }
    }
    finally
    {
      client.CheckingSections = false;
    }
  }

  private static void CheckSection_ForClient(RemoteClient client, Vector2 position, int fluff)
  {
    ActiveSections.CheckSection(position, fluff);
    int sectionX1 = Netplay.GetSectionX((int) ((double) position.X / 16.0));
    int sectionY1 = Netplay.GetSectionY((int) ((double) position.Y / 16.0));
    int num1 = 0;
    for (int x = sectionX1 - fluff; x < sectionX1 + fluff + 1; ++x)
    {
      for (int y = sectionY1 - fluff; y < sectionY1 + fluff + 1; ++y)
      {
        if (x >= 0 && x < Main.maxSectionsX && y >= 0 && y < Main.maxSectionsY)
        {
          int num2 = client.IsSectionActive(new Point(x, y)) ? 1 : 0;
          client.TileSectionsCheckTime[x, y] = Main.GameUpdateCount;
          if (num2 == 0)
            RemoteClient.NetSectionActivated(client.Id, new Point(x, y));
          if (!client.TileSections[x, y])
            ++num1;
        }
      }
    }
    if (num1 <= 0)
      return;
    int number = num1;
    NetMessage.SendData(9, client.Id, text: Lang.inter[44].ToNetworkText(), number: number);
    client.StatusText2 = Language.GetTextValue("Net.IsReceivingTileData");
    client.StatusMax += number;
    for (int sectionX2 = sectionX1 - fluff; sectionX2 < sectionX1 + fluff + 1; ++sectionX2)
    {
      for (int sectionY2 = sectionY1 - fluff; sectionY2 < sectionY1 + fluff + 1; ++sectionY2)
        NetMessage.SendSection(client.Id, sectionX2, sectionY2);
    }
  }

  public bool SectionRange(int size, int firstX, int firstY)
  {
    for (int index = 0; index < 4; ++index)
    {
      int x = firstX;
      int y = firstY;
      if (index == 1)
        x += size;
      if (index == 2)
        y += size;
      if (index == 3)
      {
        x += size;
        y += size;
      }
      if (this.TileSections[Netplay.GetSectionX(x), Netplay.GetSectionY(y)])
        return true;
    }
    return false;
  }

  public bool IsSectionActive(Point sectionCoords)
  {
    sectionCoords = sectionCoords.ClampSectionCoords();
    return this.TileSectionsCheckTime[sectionCoords.X, sectionCoords.Y] + ActiveSections.SectionInactiveTime >= Main.GameUpdateCount;
  }

  public void Reset()
  {
    Array.Clear((Array) this.TileSections, 0, this.TileSections.Length);
    Array.Clear((Array) this.TileSectionsCheckTime, 0, this.TileSectionsCheckTime.Length);
    if (this.Id < (int) byte.MaxValue)
      Main.player[this.Id] = new Player();
    this.TimeOutTimer = 0;
    this.StatusCount = 0;
    this.StatusMax = 0;
    this.StatusText2 = "";
    this.StatusText = "";
    this.State = 0;
    this._isReading = false;
    this.PendingTermination = false;
    this.PendingTerminationApproved = false;
    this.SpamClear();
    this.IsActive = false;
    NetMessage.buffer[this.Id].Reset();
    if (this.Socket == null)
      return;
    this.Socket.Close();
  }

  public void ServerWriteCallBack(object state)
  {
    --NetMessage.buffer[this.Id].spamCount;
    if (this.StatusMax <= 0)
      return;
    ++this.StatusCount;
  }

  public void Update()
  {
    if (!this.IsActive)
    {
      this.State = 0;
      this.IsActive = true;
    }
    this.TryRead();
    this.UpdateStatusText();
  }

  private void TryRead()
  {
    if (this._isReading)
      return;
    try
    {
      if (!this.Socket.IsDataAvailable() || this.ReadBufferFull)
        return;
      this._isReading = true;
      this.Socket.AsyncReceive(this.ReadBuffer, 0, this.ReadBuffer.Length, new SocketReceiveCallback(this.ServerReadCallBack));
    }
    catch
    {
      this.PendingTermination = true;
    }
  }

  private void ServerReadCallBack(object state, int length)
  {
    if (!Netplay.Disconnect)
    {
      int streamLength = length;
      if (streamLength == 0)
      {
        this.PendingTermination = true;
      }
      else
      {
        try
        {
          NetMessage.ReceiveBytes(this.ReadBuffer, streamLength, this.Id);
        }
        catch
        {
          if (!Main.ignoreErrors)
            throw;
        }
      }
    }
    this._isReading = false;
  }

  private void UpdateStatusText()
  {
    if (this.StatusMax > 0 && this.StatusText2 != "")
    {
      if (this.StatusCount >= this.StatusMax)
      {
        this.StatusText = Language.GetTextValue("Net.ClientStatusComplete", (object) this.Socket.GetRemoteAddress(), (object) this.Name, (object) this.StatusText2);
        this.StatusText2 = "";
        this.StatusMax = 0;
        this.StatusCount = 0;
      }
      else
        this.StatusText = $"({(object) this.Socket.GetRemoteAddress()}) {this.Name} {this.StatusText2}: {(object) (int) ((double) this.StatusCount / (double) this.StatusMax * 100.0)}%";
    }
    else if (this.State == 0)
      this.StatusText = Language.GetTextValue("Net.ClientConnecting", (object) $"({this.Socket.GetRemoteAddress()}) {this.Name}");
    else if (this.State == 1)
      this.StatusText = Language.GetTextValue("Net.ClientSendingData", (object) this.Socket.GetRemoteAddress(), (object) this.Name);
    else if (this.State == 2)
    {
      this.StatusText = Language.GetTextValue("Net.ClientRequestedWorldInfo", (object) this.Socket.GetRemoteAddress(), (object) this.Name);
    }
    else
    {
      if (this.State == 3)
        return;
      if (this.State != 10)
        return;
      try
      {
        this.StatusText = Language.GetTextValue("Net.ClientPlaying", (object) this.Socket.GetRemoteAddress(), (object) this.Name);
      }
      catch (Exception ex)
      {
        this.PendingTermination = true;
      }
    }
  }
}

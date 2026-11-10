// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.ChatCommands.DebugCommandAttribute
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Reflection;

#nullable disable
namespace Terraria.Testing.ChatCommands;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class DebugCommandAttribute : Attribute
{
  public readonly string Name;
  public readonly string Description;
  public readonly CommandRequirement Requirements;
  public string HelpText;

  public DebugCommandAttribute(string name, string description, CommandRequirement requirements)
  {
    this.Name = name;
    this.Description = description;
    this.Requirements = requirements;
  }

  public IDebugCommand ToDebugCommand(MethodInfo method)
  {
    return (IDebugCommand) new DebugCommandAttribute.InternalDebugCommand(this, method);
  }

  private class InternalDebugCommand : IDebugCommand
  {
    private readonly DebugCommandAttribute.InternalDebugCommand.ProcessMethod _processMethod;

    public string Name { get; private set; }

    public string Description { get; private set; }

    public string HelpText { get; private set; }

    public CommandRequirement Requirements { get; private set; }

    public InternalDebugCommand(DebugCommandAttribute attribute, MethodInfo method)
    {
      this.Name = attribute.Name;
      this.Description = attribute.Description;
      this.HelpText = attribute.HelpText;
      this.Requirements = attribute.Requirements;
      this._processMethod = (DebugCommandAttribute.InternalDebugCommand.ProcessMethod) Delegate.CreateDelegate(typeof (DebugCommandAttribute.InternalDebugCommand.ProcessMethod), method);
    }

    public bool Process(DebugMessage message) => this._processMethod(message);

    private delegate bool ProcessMethod(DebugMessage message);
  }
}

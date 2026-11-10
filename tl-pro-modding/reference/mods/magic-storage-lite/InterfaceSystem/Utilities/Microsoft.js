const Utils = new NativeClass('Terraria', 'Utils');
const MXF_Color = new NativeClass('Microsoft.Xna.Framework.Graphics', 'Color');
const MXF_Rectangle = new NativeClass('Microsoft.Xna.Framework', 'Rectangle');
const MXF_Vector2 = new NativeClass('Microsoft.Xna.Framework', 'Vector2');
export const SpriteEffects = new NativeClass('Microsoft.Xna.Framework.Graphics', 'SpriteEffects');

export class Color {
    static new(R = 255, G = 255, B = 255, A = 255) {
        const c = MXF_Color.new();
        c.R = R; c.G = G; c.B = B; c.A = A;
        return c;
    }
    
    static getByName(name) {
        return MXF_Color[name] ?? Color.new(0, 0, 0, 0);
    }
    
    constructor(R = 255, G = 255, B = 255, A = 255) {
        this._r = R;
        this._g = G;
        this._b = B;
        this._a = A;
        this._value = Color.new(R, G, B, A);
    }
    
    get R() { return this._r; }
    set R(value) {
        this._r = value;
        this._value.R = value;
    }
    
    get G() { return this._g; }
    set G(value) {
        this._g = value;
        this._value.G = value;
    }
    
    get B() { return this._b; }
    set B(value) {
        this._b = value;
        this._value.B = value;
    }
    
    get A() { return this._a; }
    set A(value) {
        this._a = value;
        this._value.A = value;
    }
    
    get Value() { return this._value; }
    set Value(value) {
        this._value = value;
        this._r = value.R;
        this._g = value.G;
        this._b = value.B;
        this._a = value.A;
    }
    
    op_Multiply(amount) {
        this.Value = MXF_Color[
        'Color op_Multiply(Color a, float amount)'
        ](this.Value, amount);
    }
    
    Multiply(amount) {
        this.Value = MXF_Color[
        'Color Multiply(Color a, float amount)'
        ](this.Value, amount);
    }
    
    Lerp(color, amount) {
        this.Value = MXF_Color[
        'Color Lerp(Color value1, Color value2, float amount)'
        ](this.Value, color, amount);
    }
    
    static op_Multiply(color, amount) {
        return MXF_Color[
        'Color op_Multiply(Color a, float amount)'
        ](color, amount);
    }
    
    static Multiply(color, amount) {
        return MXF_Color[
        'Color Multiply(Color a, float amount)'
        ](color, amount);
    }
    
    static Lerp(color1, color2, amount) {
        return MXF_Color[
        'Color Lerp(Color value1, Color value2, float amount)'
        ](color1, color2, amount);
    }
    
    static get White() { return MXF_Color.White; }
}

export class Rectangle {
    static new(x = 0, y = 0, width = 1, height = 1) {
        const r = MXF_Rectangle.new();
        r.X = x; r.Y = y; r.Width = width; r.Height = height;
        return r;
    }
    
    static Empty = () => MXF_Rectangle.Empty;
    static Size = (rect) => Utils['Vector2 Size(Rectangle r)'](rect);
    static Left = (rect) => Utils['Vector2 Left(Rectangle r)'](rect);
    static Right = (rect) => Utils['Vector2 Right(Rectangle r)'](rect);
    static Top = (rect) => Utils['Vector2 Top(Rectangle r)'](rect);
    static Bottom = (rect) => Utils['Vector2 Bottom(Rectangle r)'](rect);
    static Center = (rect) => Utils['Vector2 Center(Rectangle r)'](rect);
    static Distance = (rect, point) => Utils['float Distance(Rectangle r, Vector2 point)'](rect, point);
    static ClosestPoint = (rect, point) => Utils['Vector2 ClosestPointInRect(Rectangle r, Vector2 point)'](rect, point);
    
    constructor(x = 0, y = 0, width = 1, height = 1) {
        this._x = x;
        this._y = y;
        this._width = width;
        this._height = height;
        this._value = Rectangle.new(x, y, width, height);
    }
    
    Update() {
        this._x = this.Value.X;
        this._y = this.Value.Y;
        this._width = this.Value.Width;
        this._height = this.Value.Height;
    }
    
    get X() { return this._x; }
    set X(value) {
        this._x = value;
        this.Value.X = value;
    }
    
    get Y() { return this._y; }
    set Y(value) {
        this._y = value;
        this.Value.Y = value;
    }
    
    get Width() { return this._width; }
    set Width(value) {
        this._width = value;
        this.Value.Width = value;
    }
    
    get Height() { return this._height; }
    set Height(value) {
        this._height = value;
        this.Value.Height = value;
    }
    
    get Value() { return this._value; }
    set Value(value) {
        this._value = value;
        this._x = value.X;
        this._y = value.Y;
        this._width = value.Width;
        this._height = value.Height;
    }
    
    get Center() {
        return this.Value.get_Center();
    }
    
    get Location() {
        return this.Value.get_Location();
    }
    
    set Location(pointValue) {
        this.Value.set_Location(pointValue);
        this.Update();
    }
    
    get IsEmpty() {
        return this.Value.get_IsEmpty();
    }
    
    get Left() {
        return this.Value.get_Left();
    }
    
    get Right() {
        return this.Value.get_Right();
    }
    
    get Top() {
        return this.Value.get_Top();
    }
    
    get Bottom() {
        return this.Value.get_Bottom();
    }
    
    Contains(x, y) {
        return this.Value['bool Contains(int x, int y)'](x, y);
    }
    
    Contains_Rect(rect) {
        return this.Value['bool Contains(Rectangle value)'](rect);
    }
    
    Intersects(rect) {
        return this.Value['bool Intersects(Rectangle rect)'](rect);
    }
    
    Equals(rect) {
        return this.Value['bool Equals(Rectangle other)'](rect);
    }
    
    Offset(offsetX = 0, offsetY = 0) {
        this.Value['void Offset(int offsetX, int offsetY)'](offsetX, offsetY);
        this.Update();
    }
    
    Inflate(horizontalValue, verticalValue) {
        this.Value['void Inflate(int horizontalValue, int verticalValue)'](horizontalValue, verticalValue);
        this.Update();
    }
}

export class Vector2 {
    static new(x = 0, y = 0) {
        const v = MXF_Vector2.new();
        v.X = x; v.Y = y;
        return v;
    }
    
    static get Zero() {
        return MXF_Vector2.Zero;
    }
    
    static get One() {
        return MXF_Vector2.One;
    }
    
    static get UnitX() {
        return MXF_Vector2.UnitX;
    }
    
    static get UnitY() {
        return MXF_Vector2.UnitY;
    }
    
    static Add(v1, v2) {
        if (typeof v2 === 'number') {
            return Vector2.new(v1.X + v2, v1.Y + v2);
        }
        return MXF_Vector2['Vector2 Add(Vector2 value1, Vector2 value2)'](v1, v2);
    }
    
    static Subtract(v1, v2) {
        if (typeof v2 === 'number') {
            return Vector2.new(v1.X - v2, v1.Y - v2);
        }
        return MXF_Vector2['Vector2 Subtract(Vector2 value1, Vector2 value2)'](v1, v2);
    }
    
    static Multiply(v1, v2) {
        const method = typeof v2 === 'number'
        ? 'Vector2 Multiply(Vector2 value1, float scaleFactor)'
        : 'Vector2 Multiply(Vector2 value1, Vector2 value2)';
        return MXF_Vector2[method](v1, v2);
    }
    
    static Divide(v1, v2) {
        const method = typeof v2 === 'number'
        ? 'Vector2 Divide(Vector2 value1, float divider)'
        : 'Vector2 Divide(Vector2 value1, Vector2 value2)';
        return MXF_Vector2[method](v1, v2);
    }
    
    static Normalize(vec) {
        return MXF_Vector2['Vector2 Normalize(Vector2 value)'](vec);
    }
    
    static Distance(v1, v2) {
        return MXF_Vector2['float Distance(Vector2 value1, Vector2 value2)'](v1, v2);
    }
    
    static DistanceSquared(v1, v2) {
        return MXF_Vector2['float DistanceSquared(Vector2 value1, Vector2 value2)'](v1, v2);
    }
    
    static Dot(v1, v2) {
        return MXF_Vector2['float Dot(Vector2 value1, Vector2 value2)'](v1, v2);
    }
    
    static Lerp(v1, v2, amount) {
        return MXF_Vector2['Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)'](v1, v2, amount);
    }
    
    static ToVector2(obj) {
        if (!obj || obj.X == null || obj.Y == null)
            return Vector2.Zero;
        return Vector2.new(obj.X, obj.Y);
    }
    
    static ToRotation(vec) {
        return Utils['float ToRotation(Vector2 v)'](vec);
    }
    
    static ToRotationVector2(value) {
        return Utils['Vector2 ToRotationVector2(float f)'](value);
    }
    
    static ToPoint(vec) {
        return Utils['Point ToPoint(Vector2 v)'](vec);
    }
    
    static AngleTo(v1, v2) {
        return Utils['float AngleTo(Vector2 Origin, Vector2 Target)'](v1, v2);
    }
    
    static AngleFrom(v1, v2) {
        return Utils['float AngleFrom(Vector2 Origin, Vector2 Target)'](v1, v2);
    }
    
    static ToScreenPosition(vec) {
        return Utils['Vector2 ToScreenPosition(Vector2 worldPosition)'](vec);
    }
    
    static ToTileCoordinates(vec) {
        return Utils['Point ToTileCoordinates(Vector2 vec)'](vec);
    }
    
    constructor(x = 0, y = 0) {
        this._x = x;
        this._y = y;
        this._value = Vector2.new(x, y);
    }
    
    get X() { return this._x; }
    set X(value) {
        this._x = value;
        this.Value.X = value;
    }
    
    get Y() { return this._y; }
    set Y(value) {
        this._y = value;
        this.Value.Y = value;
    }
    
    get Value() { return this._value; }
    set Value(value) {
        this._value = value;
        this._x = value.X;
        this._y = value.Y;
    }
    
    Add(vec) {
        this.X += vec.X ?? vec;
        this.Y += vec.Y ?? vec;
        return this;
    }
    
    Subtract(vec) {
        this.X -= vec.X ?? vec;
        this.Y -= vec.Y ?? vec;
        return this;
    }
    
    Multiply(vec) {
        this.X *= vec.X ?? vec;
        this.Y *= vec.Y ?? vec;
        return this;
    }
    
    Divide(vec) {
        this.X /= vec.X ?? vec;
        this.Y /= vec.Y ?? vec;
        return this;
    }
    
    Negate() {
        this.X *= -1;
        this.Y *= -1;
        return this;
    }
    
    Max(vec) {
        this.X = Math.max(this.X, vec.X ?? vec);
        this.Y = Math.max(this.Y, vec.Y ?? vec);
        return this;
    }

    Min(vec) {
        this.X = Math.min(this.X, vec.X ?? vec);
        this.Y = Math.min(this.Y, vec.Y ?? vec);
        return this;
    }
    
    Normalize() {
        const len = Math.sqrt(this.X * this.X + this.Y * this.Y);
        if (len === 0) {
            this.X = 0;
            this.Y = 0;
        } else {
            this.X /= len;
            this.Y /= len;
        }
        return this;
    }
    
    Length() {
        return this.Value['float Length()']();
    }
    
    LengthSquared() {
        return this.Value['float LengthSquared()']();
    }
}
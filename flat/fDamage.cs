// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::FlatBuffers;

public struct fDamage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static fDamage GetRootAsfDamage(ByteBuffer _bb) { return GetRootAsfDamage(_bb, new fDamage()); }
  public static fDamage GetRootAsfDamage(ByteBuffer _bb, fDamage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public fDamage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Class CType { get { int o = __p.__offset(4); return o != 0 ? (Class)__p.bb.GetInt(o + __p.bb_pos) : Class.Base; } }
  public int Damage { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Vec3? Pos { get { int o = __p.__offset(8); return o != 0 ? (Vec3?)(new Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public bool BCri { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static void StartfDamage(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddCType(FlatBufferBuilder builder, Class cType) { builder.AddInt(0, (int)cType, 0); }
  public static void AddDamage(FlatBufferBuilder builder, int damage) { builder.AddInt(1, damage, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<Vec3> PosOffset) { builder.AddStruct(2, PosOffset.Value, 0); }
  public static void AddBCri(FlatBufferBuilder builder, bool bCri) { builder.AddBool(3, bCri, false); }
  public static Offset<fDamage> EndfDamage(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<fDamage>(o);
  }
};


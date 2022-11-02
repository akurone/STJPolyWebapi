using System.Text.Json.Serialization;

namespace STJPolyWebapi;

[JsonPolymorphic, JsonDerivedType(typeof(DerivedA), nameof(DerivedA))]
public class SomeBaseType { public int Prop1 { get; set; } = 1; }

public class DerivedA : SomeBaseType { public int Prop2 { get; set; } = 2; }

public class Wrapper { public SomeBaseType? Wrapped { get; set; } }
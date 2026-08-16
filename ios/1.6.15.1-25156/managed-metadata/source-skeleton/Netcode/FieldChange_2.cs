namespace Netcode;

public delegate void FieldChange<in TSelf, in TValue>(TSelf field, TValue oldValue, TValue newValue);

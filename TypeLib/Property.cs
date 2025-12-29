using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.MetaModelTypeLib.TypeLib;

/// <summary>
/// The class of RDF properties.
/// </summary>
[CimClass(ClassUri)]
public partial class Property(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri
        = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Property";

    /// <summary>
    /// 
    /// </summary>
    public Class? domain
    {
        get => GetAssoc1To1<Class>(nameof(domain));
        set => SetAssoc1To1(nameof(domain), value);
    }

    /// <summary>
    /// 
    /// </summary>
    public MultiplicityClass? multiplicity
    {
        get => GetAssoc1To1<MultiplicityClass>(nameof(multiplicity));
        set => SetAssoc1To1(nameof(multiplicity), value);
    }

    /// <summary>
    /// 
    /// </summary>
    public Class? dataType
    {
        get => GetAssoc1To1<Class>(nameof(dataType));
        set => SetAssoc1To1(nameof(dataType), value);
    }

    /// <summary>
    /// 
    /// </summary>
    public Property? inverseRoleName
    {
        get => GetAssoc1To1<Property>(nameof(inverseRoleName));
        set => SetAssoc1To1(nameof(inverseRoleName), value);
    }

    /// <summary>
    /// 
    /// </summary>
    public Class? range
    {
        get => GetAssoc1To1<Class>(nameof(range));
        set => SetAssoc1To1(nameof(range), value);
    }
}
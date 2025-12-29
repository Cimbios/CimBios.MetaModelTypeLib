using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.MetaModelTypeLib.TypeLib;

/// <summary>
/// Class category - uml package.
/// </summary>
[CimClass(ClassUri)]
public partial class ClassCategory(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Class(oid, metaClass)
{
    public new const string ClassUri
        = "http://iec.ch/TC57/1999/rdf-schema-extensions-19990926#ClassCategory";

    // Non-serializable

    public string? NamespacePrefix { get; set; }

    public Uri? NamespaceUri { get; set; }

    //
}
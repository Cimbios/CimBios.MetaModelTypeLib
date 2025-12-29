using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.MetaModelTypeLib.TypeLib;

/// <summary>
/// rdf:Description meta instance.
/// </summary>
[CimClass(ClassUri)]
public partial class Description(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri
        = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Description";
}
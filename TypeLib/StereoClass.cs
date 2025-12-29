using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.MetaModelTypeLib.TypeLib;

/// <summary>
/// 
/// </summary>
[CimClass(ClassUri)]
public partial class StereoClass(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri
        = "http://cim.bios/schema#StereoClass";
}
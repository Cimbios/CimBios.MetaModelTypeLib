using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.MetaModelTypeLib.TypeLib;

/// <summary>
/// 
/// </summary>
[CimClass(ClassUri)]
public partial class Class(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri
        = "http://www.w3.org/2000/01/rdf-schema#Class";

    /// <summary>
    /// 
    /// </summary>
    public Class[] subClassOf => GetAssoc1ToM<Class>(nameof(subClassOf));

    public void AddToSubClassOf(Class assocObject)
        => AddAssoc1ToM(nameof(subClassOf), assocObject);

    public void RemoveFromSubClassOf(Class assocObject)
        => RemoveAssoc1ToM(nameof(subClassOf), assocObject);

    public void RemoveAllFromSubClassOf()
        => RemoveAllAssocs1ToM(nameof(subClassOf));
}
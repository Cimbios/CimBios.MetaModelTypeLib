/*
 *    CimBios.Gost58651 - RF CIM Canonical model classes C# implementation.
 *    Copyright (C) 2025 Yuri A. Kovalenko a.k.a belizahrt <belizahrt@gmail.com>
 *
 *    This program is free software: you can redistribute it and/or modify
 *    it under the terms of the GNU General Public License as published by
 *    the Free Software Foundation, either version 3 of the License, or
 *    (at your option) any later version.
 *
 *    This program is distributed in the hope that it will be useful,
 *    but WITHOUT ANY WARRANTY; without even the implied warranty of
 *    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *    GNU General Public License for more details.
 *
 *    You should have received a copy of the GNU General Public License
 *    along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.ModelObject;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.MetaModelTypeLib.TypeLib;

/// <summary>
/// Root rdfs:Resource meta instance.
/// </summary>
[CimClass(ClassUri)]
public partial class Resource(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ModelObject(oid, metaClass)
{
    public const string ClassUri
        = "http://www.w3.org/2000/01/rdf-schema#Resource";

    // Non-serializable
    public bool IsPrivate { get; set; } = false;
    //

    /// <summary>
    /// A label of the subject resource.
    /// </summary>
    public string? label
    {
        get => GetAttribute<string?>(nameof(label));
        set => SetAttribute(nameof(label), value);
    }

    /// <summary>
    /// A description of the subject resource.
    /// </summary>
    public string? comment
    {
        get => GetAttribute<string?>(nameof(comment));
        set => SetAttribute(nameof(comment), value);
    }

    /// <summary>
    /// The subject is an instance of a class.
    /// </summary>
    public Class? type
    {
        get => GetAssoc1To1<Class>(nameof(type));
        set => SetAssoc1To1(nameof(type), value);
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassCategory? belongsToCategory
    {
        get => GetAssoc1To1<ClassCategory>(nameof(belongsToCategory));
        set => SetAssoc1To1(nameof(belongsToCategory), value);
    }

    /// <summary>
    /// 
    /// </summary>
    public StereoClass[] stereotype => GetAssoc1ToM<StereoClass>(nameof(stereotype));

    public void AddToStereotype(StereoClass assocObject)
        => AddAssoc1ToM(nameof(stereotype), assocObject);

    public void RemoveFromStereotype(StereoClass assocObject)
        => RemoveAssoc1ToM(nameof(stereotype), assocObject);

    public void RemoveAllFromStereotype()
        => RemoveAllAssocs1ToM(nameof(stereotype));
}
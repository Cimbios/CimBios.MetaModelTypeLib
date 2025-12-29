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

using System.Reflection;
using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.Factory;
using CimBios.Core.CimModel.Schema;
using CimBios.Core.CimModel.Schema.RdfSchema;

namespace CimBios.MetaModelTypeLib.Factory;

/// <summary>
/// CimBios RDFS Meta CIM Canonical model classes C# implementation.
/// </summary>
public class MetaModelTypeLibFactory : ICimDatatypeLibFactory
{
    public ICimDatatypeLib Create()
    {
        var schema = new CimRdfSchemaXmlFactory().CreateSchema();
        schema.Load(new StreamReader("Schemas/MetaModel.rdfs"));

        return Create(schema);
    }

    public ICimDatatypeLib Create(ICimSchema schema)
    {
        var thisAssemblyName = Assembly.GetExecutingAssembly().GetName().Name;

        if (string.IsNullOrEmpty(thisAssemblyName))
            throw new InvalidProgramException("Empty type lib assembly name!");
        
        return new CimDatatypeLib(thisAssemblyName, schema);
    }
}
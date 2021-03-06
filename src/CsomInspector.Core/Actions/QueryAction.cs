﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CsomInspector.Core.Actions
{
	public class QueryAction : ActionBase
	{
		private QueryAction(IEnumerable<String> selectedProperties, IEnumerable<String> selectedChildProperties)
		{
			_propertiesNode = CreatePropertiesNode(selectedProperties, "Select all properties", "Selected properties:");
			_childPropertiesNode = CreatePropertiesNode(selectedChildProperties, "Select all child properties", "Selected child properties:");
		}

		private IObjectTreeNode CreatePropertiesNode(IEnumerable<String> selectedProperties, String allText, String selectedText)
		{
			if (selectedProperties == null)
			{
				return new ObjectTreeNode(allText, Enumerable.Empty<IObjectTreeNode>());
			}

			var properties = selectedProperties.Select(p => new ObjectTreeNode(p, Enumerable.Empty<IObjectTreeNode>()));
			return new ObjectTreeNode(selectedText, properties);
		}

		private IObjectTreeNode _propertiesNode;
		private IObjectTreeNode _childPropertiesNode;

		public override IEnumerable<IObjectTreeNode> Children => new[] {
			_propertiesNode,
			_childPropertiesNode
		};

		public override String ToString() => "Load (Query element)";

		internal static new QueryAction FromXml(XElement element)
		{
			var selectedProperties = GetProperties(element, "Query");
			var selectedChildProperties = GetProperties(element, "ChildItemQuery");

			return new QueryAction(selectedProperties, selectedChildProperties);
		}

		private static IEnumerable<String> GetProperties(XElement queryElement, String childElementName)
		{
			var element = queryElement.Element(XName.Get(childElementName, _elementNamespace));

			//TODO: TEMP FIX - this will cause "SelectAllProperties = true" to display for items without child items
			if (element == null)
			{
				return null;
			}

			var allPropertiesAttribute = element.Attribute(XName.Get("SelectAllProperties"));

			if (String.Equals("True", allPropertiesAttribute.Value, StringComparison.InvariantCultureIgnoreCase))
			{
				return null;
			}

			var propertyElements = element.Element(XName.Get("Properties", _elementNamespace))?.Elements(XName.Get("Property", _elementNamespace));
			var nameAttributes = propertyElements.Attributes(XName.Get("Name"));

			return nameAttributes.Select(a => a.Value);
		}
	}
}
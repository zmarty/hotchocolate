using System.Collections.Generic;

namespace StrawberryShake.CodeGeneration
{
    public class NamedTypeReferenceDescriptor
        : TypeReferenceDescriptor
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        public string Name { get; }

        public bool IsListType => ListType == ListType.List || ListType == ListType.NullableList;

        public NamedTypeReferenceDescriptor(TypeDescriptor type, bool isNullable, ListType listType, string name) : base(type,
            isNullable,
            listType
        )
        {
            Name = name;
        }
    }
}
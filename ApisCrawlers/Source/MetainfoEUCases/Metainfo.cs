﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 
namespace MetainfoEUCases
{

    /// <summary>
    /// Provide information for a single document group.
    /// Since there are documents that are composed of group of files, 
    /// they need to be combined in Document group to keep their consistency.
    /// To ensure this we need to put every document in a XmlDocumentGroup object(even the document is composed by single document)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("documentgroup", AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "documentgroup")]
    public partial class XmlDocumentGroup
    {

        private List<XmlDocumentMetaInfo> documentField;

        private string dateField;

        private string crawlerField;

        private string langField;

        private string formatField;

        private string fileNameField;

        private string identifierField;

        private Operation operationField;

        /// <summary>
        /// Constructor
        /// </summary>
        public XmlDocumentGroup()
        {
            this.Document = new List<XmlDocumentMetaInfo>();
        }

        /// <summary>
        /// List of XmlDocumentMetaInfo objects
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("document", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<XmlDocumentMetaInfo> Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }

        /// <summary>
        /// string representation of date and time when document group is downloaded
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("date")]
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <summary>
        /// sting identifier of crawler donloading documents
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("crawler")]
        public string Crawler
        {
            get
            {
                return this.crawlerField;
            }
            set
            {
                this.crawlerField = value;
            }
        }

        /// <summary>
        /// language of crawled document group
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lang")]
        public string Lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <summary>
        /// Defines the file type of document group in Internal Media Type
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("format")]
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <summary>
        /// string filename of document group
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("filename")]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <summary>
        /// unique identifier of documentgroup across all crawlers. To ensure this identifier must be GUID
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("identifier")]
        public string Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <summary>
        /// Operation for this document group
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("operation")]
        public Operation Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
    }

    /// <summary>
    /// Provides information for single document
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("document", AnonymousType = true)]
    public partial class XmlDocumentMetaInfo
    {
        private byte[] dataContentField;

        private string formatField;

        private string fileField;

        private string identifierField;

        private Operation operationField;

        private string urlField;

        private string md5Field;

        /// <summary>
        /// Binary representation of crawled document
        /// </summary>
        [XmlIgnore]
        public byte[] DataContent
        {
            get
            {
                return this.dataContentField;
            }
            set
            {
                this.dataContentField = value;
            }
        }

        /// <summary>
        /// Defines the file type of document in Internal Media Type(MIME) 
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("format")]
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <summary>
        /// Name of crawled document
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("file")]
        public string File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <summary>
        /// – unique identifier of document across all crawlers. To ensure this identifier must be GUID
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("identifier")]
        public string Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <summary>
        /// Operation for document see Operation enum
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("operation")]
        public Operation Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }

        /// <summary>
        /// URL address from where document is downloaded
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <summary>
        /// MD5 hash of document
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("md5")]
        public string Md5
        {
            get
            {
                return this.md5Field;
            }
            set
            {
                this.md5Field = value;
            }
        }
    }
}
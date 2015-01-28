// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>ovf-core</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace ovf_core {

    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;

	[Serializable]
    public partial class AnnotationSection_Type : Section_Type {
        
        private List<Info_Type> annotationField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public AnnotationSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.annotationField = new List<Info_Type>();
        }
        
        public List<Info_Type> Annotation {
            get {
                return this.annotationField;
            }
            set {
                this.annotationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class Info_Type {
        
        private string langField;
        
        private string valueField;
        
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

	[Serializable]
    public partial class VirtualDiskDesc_Type {
        
        private string diskIdField;
        
        private string fileRefField;
        
        private string capacityField;
        
        private string formatField;
        
        private long populatedSizeField;
        
        private bool populatedSizeFieldSpecified;
        
        private string parentRefField;
        
        public string diskId {
            get {
                return this.diskIdField;
            }
            set {
                this.diskIdField = value;
            }
        }
        
        public string fileRef {
            get {
                return this.fileRefField;
            }
            set {
                this.fileRefField = value;
            }
        }
        
        public string capacity {
            get {
                return this.capacityField;
            }
            set {
                this.capacityField = value;
            }
        }
        
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        public long populatedSize {
            get {
                return this.populatedSizeField;
            }
            set {
                this.populatedSizeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool populatedSizeSpecified {
            get {
                return this.populatedSizeFieldSpecified;
            }
            set {
                this.populatedSizeFieldSpecified = value;
            }
        }
        
        public string parentRef {
            get {
                return this.parentRefField;
            }
            set {
                this.parentRefField = value;
            }
        }
    }

	[Serializable]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnnotationSection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstallSection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartupSection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EulaSection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatingSystemSection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CpuCompatibilitySection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiskSection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkSection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertySection_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductSection_Type))]
    public abstract partial class Section_Type {
        
        private List<Info_Type> infoField;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        private List<System.Xml.XmlAttribute> anyAttrField;
        
        public Section_Type() {
            this.anyAttrField = new List<System.Xml.XmlAttribute>();
            this.infoField = new List<Info_Type>();
        }
        
        public List<Info_Type> Info {
            get {
                return this.infoField;
            }
            set {
                this.infoField = value;
            }
        }
        
        public bool required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requiredSpecified {
            get {
                return this.requiredFieldSpecified;
            }
            set {
                this.requiredFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }

	[Serializable]
    public partial class InstallSection_Type : Section_Type {
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private string transportField;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public InstallSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        public string transport {
            get {
                return this.transportField;
            }
            set {
                this.transportField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class StartupSection_Type : Section_Type {
        
        private List<StartupSection_TypeItem> itemField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public StartupSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.itemField = new List<StartupSection_TypeItem>();
        }
        
        public List<StartupSection_TypeItem> item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class StartupSection_TypeItem {
        
        private string idField;
        
        private int orderField;
        
        private bool orderFieldSpecified;
        
        private int startDelayField;
        
        private bool startDelayFieldSpecified;
        
        private bool waitingForGuestField;
        
        private bool waitingForGuestFieldSpecified;
        
        private int stopDelayField;
        
        private bool stopDelayFieldSpecified;
        
        private string startActionField;
        
        private string stopActionField;
        
        private List<System.Xml.XmlAttribute> anyAttrField;
        
        public StartupSection_TypeItem() {
            this.anyAttrField = new List<System.Xml.XmlAttribute>();
        }
        
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public int order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderSpecified {
            get {
                return this.orderFieldSpecified;
            }
            set {
                this.orderFieldSpecified = value;
            }
        }
        
        public int startDelay {
            get {
                return this.startDelayField;
            }
            set {
                this.startDelayField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDelaySpecified {
            get {
                return this.startDelayFieldSpecified;
            }
            set {
                this.startDelayFieldSpecified = value;
            }
        }
        
        public bool waitingForGuest {
            get {
                return this.waitingForGuestField;
            }
            set {
                this.waitingForGuestField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool waitingForGuestSpecified {
            get {
                return this.waitingForGuestFieldSpecified;
            }
            set {
                this.waitingForGuestFieldSpecified = value;
            }
        }
        
        public int stopDelay {
            get {
                return this.stopDelayField;
            }
            set {
                this.stopDelayField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stopDelaySpecified {
            get {
                return this.stopDelayFieldSpecified;
            }
            set {
                this.stopDelayFieldSpecified = value;
            }
        }
        
        public string startAction {
            get {
                return this.startActionField;
            }
            set {
                this.startActionField = value;
            }
        }
        
        public string stopAction {
            get {
                return this.stopActionField;
            }
            set {
                this.stopActionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }

	[Serializable]
    public partial class EulaSection_Type : Section_Type {
        
        private List<Info_Type> licenseField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public EulaSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.licenseField = new List<Info_Type>();
        }
        
        public List<Info_Type> License {
            get {
                return this.licenseField;
            }
            set {
                this.licenseField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class OperatingSystemSection_Type : Section_Type {
        
        private List<Info_Type> descriptionField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private string idField;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public OperatingSystemSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.descriptionField = new List<Info_Type>();
        }
        
        public List<Info_Type> Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class CpuCompatibilitySection_Type : Section_Type {
        
        private List<CpuCompatibilitySection_TypeLevel> levelField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private string vendorField;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public CpuCompatibilitySection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.levelField = new List<CpuCompatibilitySection_TypeLevel>();
        }
        
        public List<CpuCompatibilitySection_TypeLevel> Level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        public string Vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class CpuCompatibilitySection_TypeLevel {
        
        private int levelField;
        
        private bool levelFieldSpecified;
        
        private string eaxField;
        
        private string ebxField;
        
        private string ecxField;
        
        private string edxField;
        
        public int level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelSpecified {
            get {
                return this.levelFieldSpecified;
            }
            set {
                this.levelFieldSpecified = value;
            }
        }
        
        public string eax {
            get {
                return this.eaxField;
            }
            set {
                this.eaxField = value;
            }
        }
        
        public string ebx {
            get {
                return this.ebxField;
            }
            set {
                this.ebxField = value;
            }
        }
        
        public string ecx {
            get {
                return this.ecxField;
            }
            set {
                this.ecxField = value;
            }
        }
        
        public string edx {
            get {
                return this.edxField;
            }
            set {
                this.edxField = value;
            }
        }
    }

	[Serializable]
    public partial class DiskSection_Type : Section_Type {
        
        private List<VirtualDiskDesc_Type> diskField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public DiskSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.diskField = new List<VirtualDiskDesc_Type>();
        }
        
        public List<VirtualDiskDesc_Type> Disk {
            get {
                return this.diskField;
            }
            set {
                this.diskField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class NetworkSection_Type : Section_Type {
        
        private List<NetworkSection_TypeNetwork> networkField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public NetworkSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.networkField = new List<NetworkSection_TypeNetwork>();
        }
        
        public List<NetworkSection_TypeNetwork> Network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class NetworkSection_TypeNetwork {
        
        private List<Info_Type> descriptionField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private string nameField;
        
        private List<System.Xml.XmlAttribute> anyAttrField;
        
        public NetworkSection_TypeNetwork() {
            this.anyAttrField = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.descriptionField = new List<Info_Type>();
        }
        
        public List<Info_Type> Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }

	[Serializable]
    public partial class PropertySection_Type : Section_Type {
        
        private List<PropertySection_TypeProperty> propertyField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private string transportField;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public PropertySection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.propertyField = new List<PropertySection_TypeProperty>();
        }
        
        public List<PropertySection_TypeProperty> Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        public string transport {
            get {
                return this.transportField;
            }
            set {
                this.transportField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }

	[Serializable]
    public partial class PropertySection_TypeProperty {
        
        private List<Info_Type> descriptionField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private string keyField;
        
        private string typeField;
        
        private bool configurableByUserField;
        
        private bool configurableByUserFieldSpecified;
        
        private bool configurableAtRuntimeField;
        
        private bool configurableAtRuntimeFieldSpecified;
        
        private string defaultValueField;
        
        private List<System.Xml.XmlAttribute> anyAttrField;
        
        public PropertySection_TypeProperty() {
            this.anyAttrField = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.descriptionField = new List<Info_Type>();
        }
        
        public List<Info_Type> Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        public bool configurableByUser {
            get {
                return this.configurableByUserField;
            }
            set {
                this.configurableByUserField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool configurableByUserSpecified {
            get {
                return this.configurableByUserFieldSpecified;
            }
            set {
                this.configurableByUserFieldSpecified = value;
            }
        }
        
        public bool configurableAtRuntime {
            get {
                return this.configurableAtRuntimeField;
            }
            set {
                this.configurableAtRuntimeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool configurableAtRuntimeSpecified {
            get {
                return this.configurableAtRuntimeFieldSpecified;
            }
            set {
                this.configurableAtRuntimeFieldSpecified = value;
            }
        }
        
        public string defaultValue {
            get {
                return this.defaultValueField;
            }
            set {
                this.defaultValueField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }

	[Serializable]
    public partial class ProductSection_Type : Section_Type {
        
        private List<Info_Type> productField;
        
        private List<Info_Type> vendorField;
        
        private string versionField;
        
        private string fullversionField;
        
        private string productUrlField;
        
        private string vendorUrlField;
        
        private string appUrlField;
        
        private List<System.Xml.XmlElement> anyField;
        
        private List<System.Xml.XmlElement> any1Field;
        
        private List<System.Xml.XmlAttribute> anyAttr1Field;
        
        public ProductSection_Type() {
            this.anyAttr1Field = new List<System.Xml.XmlAttribute>();
            this.any1Field = new List<System.Xml.XmlElement>();
            this.anyField = new List<System.Xml.XmlElement>();
            this.vendorField = new List<Info_Type>();
            this.productField = new List<Info_Type>();
        }
        
        public List<Info_Type> Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        public List<Info_Type> Vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
        
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        public string Fullversion {
            get {
                return this.fullversionField;
            }
            set {
                this.fullversionField = value;
            }
        }
        
        public string ProductUrl {
            get {
                return this.productUrlField;
            }
            set {
                this.productUrlField = value;
            }
        }
        
        public string VendorUrl {
            get {
                return this.vendorUrlField;
            }
            set {
                this.vendorUrlField = value;
            }
        }
        
        public string AppUrl {
            get {
                return this.appUrlField;
            }
            set {
                this.appUrlField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=7)]
        public List<System.Xml.XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=8)]
        public List<System.Xml.XmlElement> Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1 {
            get {
                return this.anyAttr1Field;
            }
            set {
                this.anyAttr1Field = value;
            }
        }
    }
}
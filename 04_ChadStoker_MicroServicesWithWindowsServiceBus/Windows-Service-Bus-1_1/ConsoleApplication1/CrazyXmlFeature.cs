using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class ShowingCoolXmlTrick
    {
        public ShowingCoolXmlTrick()
        {
            FileStream sr1 = new FileStream("WSPTest.xml", FileMode.Open);
            root r = Program.Deserialize<root>(sr1); //IT WORKS! Whoah!
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class root
    {

        private Person personField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public Person Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = false)]
    public partial class Person
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Offense", typeof(Offense), Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
        [System.Xml.Serialization.XmlElementAttribute("Probation", typeof(Probation), Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
        [System.Xml.Serialization.XmlElementAttribute("Document", typeof(PersonDocument))]
        [System.Xml.Serialization.XmlElementAttribute("LocationAddress", typeof(PersonLocationAddress))]
        [System.Xml.Serialization.XmlElementAttribute("PersonBirthDate", typeof(PersonPersonBirthDate))]
        [System.Xml.Serialization.XmlElementAttribute("PersonName", typeof(PersonPersonName))]
        [System.Xml.Serialization.XmlElementAttribute("PeopleStatus", typeof(string), Namespace = "http://www.offenderwatch.com")]
        [System.Xml.Serialization.XmlElementAttribute("RegisteringAgency", typeof(RegisteringAgency), Namespace = "http://www.offenderwatch.com")]
        [System.Xml.Serialization.XmlElementAttribute("RiskLevel", typeof(string), Namespace = "http://www.offenderwatch.com")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.1", IsNullable = false)]
    public partial class Offense
    {

        private Case caseField;

        private string offenseCountyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public Case Case
        {
            get
            {
                return this.caseField;
            }
            set
            {
                this.caseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.offenderwatch.com")]
        public string OffenseCounty
        {
            get
            {
                return this.offenseCountyField;
            }
            set
            {
                this.offenseCountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = false)]
    public partial class Case
    {

        private CaseActivityIdentification activityIdentificationField;

        /// <remarks/>
        public CaseActivityIdentification ActivityIdentification
        {
            get
            {
                return this.activityIdentificationField;
            }
            set
            {
                this.activityIdentificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class CaseActivityIdentification
    {

        private string identificationIDField;

        /// <remarks/>
        public string IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.1", IsNullable = false)]
    public partial class Probation
    {

        private SupervisionSupervisor supervisionSupervisorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public SupervisionSupervisor SupervisionSupervisor
        {
            get
            {
                return this.supervisionSupervisorField;
            }
            set
            {
                this.supervisionSupervisorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = false)]
    public partial class SupervisionSupervisor
    {

        private SupervisionSupervisorPerson personField;

        /// <remarks/>
        public SupervisionSupervisorPerson Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class SupervisionSupervisorPerson
    {

        private SupervisionSupervisorPersonPersonName personNameField;

        /// <remarks/>
        public SupervisionSupervisorPersonPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class SupervisionSupervisorPersonPersonName
    {

        private string personFullNameField;

        /// <remarks/>
        public string PersonFullName
        {
            get
            {
                return this.personFullNameField;
            }
            set
            {
                this.personFullNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonDocument
    {

        private PersonDocumentDocument documentField;

        private string idField;

        /// <remarks/>
        public PersonDocumentDocument Document
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonDocumentDocument
    {

        private PersonDocumentDocumentDocumentStatus documentStatusField;

        private PersonDocumentDocumentImage imageField;

        /// <remarks/>
        public PersonDocumentDocumentDocumentStatus DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }

        /// <remarks/>
        public PersonDocumentDocumentImage Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonDocumentDocumentDocumentStatus
    {

        private string statusTextField;

        /// <remarks/>
        public string StatusText
        {
            get
            {
                return this.statusTextField;
            }
            set
            {
                this.statusTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonDocumentDocumentImage
    {

        private string binaryBase64ObjectField;

        /// <remarks/>
        public string BinaryBase64Object
        {
            get
            {
                return this.binaryBase64ObjectField;
            }
            set
            {
                this.binaryBase64ObjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonLocationAddress
    {

        private OffenderAddress offenderAddressField;

        private PersonLocationAddressAssociationBeginDate associationBeginDateField;

        private PersonLocationAddressAssociationEndDate associationEndDateField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.offenderwatch.com")]
        public OffenderAddress OffenderAddress
        {
            get
            {
                return this.offenderAddressField;
            }
            set
            {
                this.offenderAddressField = value;
            }
        }

        /// <remarks/>
        public PersonLocationAddressAssociationBeginDate AssociationBeginDate
        {
            get
            {
                return this.associationBeginDateField;
            }
            set
            {
                this.associationBeginDateField = value;
            }
        }

        /// <remarks/>
        public PersonLocationAddressAssociationEndDate AssociationEndDate
        {
            get
            {
                return this.associationEndDateField;
            }
            set
            {
                this.associationEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.offenderwatch.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.offenderwatch.com", IsNullable = false)]
    public partial class OffenderAddress
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredAddress", typeof(StructuredAddress), Namespace = "http://niem.gov/niem/niem-core/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("AddressClass", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = false)]
    public partial class StructuredAddress
    {

        private string locationCityNameField;

        private string locationStateUSPostalServiceCodeField;

        private string locationPostalCodeField;

        private string locationCountyNameField;

        private string locationCountryNameField;

        private StructuredAddressLocationStreet locationStreetField;

        private string addressBuildingTextField;

        /// <remarks/>
        public string LocationCityName
        {
            get
            {
                return this.locationCityNameField;
            }
            set
            {
                this.locationCityNameField = value;
            }
        }

        /// <remarks/>
        public string LocationStateUSPostalServiceCode
        {
            get
            {
                return this.locationStateUSPostalServiceCodeField;
            }
            set
            {
                this.locationStateUSPostalServiceCodeField = value;
            }
        }

        /// <remarks/>
        public string LocationPostalCode
        {
            get
            {
                return this.locationPostalCodeField;
            }
            set
            {
                this.locationPostalCodeField = value;
            }
        }

        /// <remarks/>
        public string LocationCountyName
        {
            get
            {
                return this.locationCountyNameField;
            }
            set
            {
                this.locationCountyNameField = value;
            }
        }

        /// <remarks/>
        public string LocationCountryName
        {
            get
            {
                return this.locationCountryNameField;
            }
            set
            {
                this.locationCountryNameField = value;
            }
        }

        /// <remarks/>
        public StructuredAddressLocationStreet LocationStreet
        {
            get
            {
                return this.locationStreetField;
            }
            set
            {
                this.locationStreetField = value;
            }
        }

        /// <remarks/>
        public string AddressBuildingText
        {
            get
            {
                return this.addressBuildingTextField;
            }
            set
            {
                this.addressBuildingTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class StructuredAddressLocationStreet
    {

        private string streetNameField;

        /// <remarks/>
        public string StreetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonLocationAddressAssociationBeginDate
    {

        private string dateField;

        /// <remarks/>
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonLocationAddressAssociationEndDate
    {

        private string dateField;

        /// <remarks/>
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonPersonBirthDate
    {

        private string dateField;

        /// <remarks/>
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonPersonName
    {

        private string personGivenNameField;

        private string personMiddleNameField;

        private string personSurNameField;

        private string personNameSuffixTextField;

        /// <remarks/>
        public string PersonGivenName
        {
            get
            {
                return this.personGivenNameField;
            }
            set
            {
                this.personGivenNameField = value;
            }
        }

        /// <remarks/>
        public string PersonMiddleName
        {
            get
            {
                return this.personMiddleNameField;
            }
            set
            {
                this.personMiddleNameField = value;
            }
        }

        /// <remarks/>
        public string PersonSurName
        {
            get
            {
                return this.personSurNameField;
            }
            set
            {
                this.personSurNameField = value;
            }
        }

        /// <remarks/>
        public string PersonNameSuffixText
        {
            get
            {
                return this.personNameSuffixTextField;
            }
            set
            {
                this.personNameSuffixTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.offenderwatch.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.offenderwatch.com", IsNullable = false)]
    public partial class RegisteringAgency
    {

        private Agency agencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public Agency Agency
        {
            get
            {
                return this.agencyField;
            }
            set
            {
                this.agencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/niem-core/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = false)]
    public partial class Agency
    {

        private SubjectStatus subjectStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
        public SubjectStatus SubjectStatus
        {
            get
            {
                return this.subjectStatusField;
            }
            set
            {
                this.subjectStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.1", IsNullable = false)]
    public partial class SubjectStatus
    {

        private SubjectStatusRegisteredSexOffender registeredSexOffenderField;

        /// <remarks/>
        public SubjectStatusRegisteredSexOffender RegisteredSexOffender
        {
            get
            {
                return this.registeredSexOffenderField;
            }
            set
            {
                this.registeredSexOffenderField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class SubjectStatusRegisteredSexOffender
    {

        private SubjectStatusRegisteredSexOffenderRegisteredOffenderStartDate registeredOffenderStartDateField;

        private SubjectStatusRegisteredSexOffenderRegisteredOffenderEndDate registeredOffenderEndDateField;

        private SubjectStatusRegisteredSexOffenderSubjectStatus subjectStatusField;

        /// <remarks/>
        public SubjectStatusRegisteredSexOffenderRegisteredOffenderStartDate RegisteredOffenderStartDate
        {
            get
            {
                return this.registeredOffenderStartDateField;
            }
            set
            {
                this.registeredOffenderStartDateField = value;
            }
        }

        /// <remarks/>
        public SubjectStatusRegisteredSexOffenderRegisteredOffenderEndDate RegisteredOffenderEndDate
        {
            get
            {
                return this.registeredOffenderEndDateField;
            }
            set
            {
                this.registeredOffenderEndDateField = value;
            }
        }

        /// <remarks/>
        public SubjectStatusRegisteredSexOffenderSubjectStatus SubjectStatus
        {
            get
            {
                return this.subjectStatusField;
            }
            set
            {
                this.subjectStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class SubjectStatusRegisteredSexOffenderRegisteredOffenderStartDate
    {

        private string dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class SubjectStatusRegisteredSexOffenderRegisteredOffenderEndDate
    {

        private string dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class SubjectStatusRegisteredSexOffenderSubjectStatus
    {

        private string statusTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
        public string StatusText
        {
            get
            {
                return this.statusTextField;
            }
            set
            {
                this.statusTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://niem.gov/niem/domains/jxdm/4.1:Offense")]
        Offense,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://niem.gov/niem/domains/jxdm/4.1:Probation")]
        Probation,

        /// <remarks/>
        Document,

        /// <remarks/>
        LocationAddress,

        /// <remarks/>
        PersonBirthDate,

        /// <remarks/>
        PersonName,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.offenderwatch.com:PeopleStatus")]
        PeopleStatus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.offenderwatch.com:RegisteringAgency")]
        RegisteringAgency,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.offenderwatch.com:RiskLevel")]
        RiskLevel,
    }


}

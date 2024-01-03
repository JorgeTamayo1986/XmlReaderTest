using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReaderTest
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeHeader headerField;

        private EnvelopeBody bodyField;

        private string encodingStyleField;

        /// <remarks/>
        public EnvelopeHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string encodingStyle
        {
            get
            {
                return this.encodingStyleField;
            }
            set
            {
                this.encodingStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeHeader
    {

        private Transaction transactionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "xxs")]
        public Transaction Transaction
        {
            get
            {
                return this.transactionField;
            }
            set
            {
                this.transactionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "xxs")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "xxs", IsNullable = false)]
    public partial class Transaction
    {

        private tc tcField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public tc tc
        {
            get
            {
                return this.tcField;
            }
            set
            {
                this.tcField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class tc
    {

        private string pidField;

        private string tidField;

        private System.DateTime dtField;

        /// <remarks/>
        public string pid
        {
            get
            {
                return this.pidField;
            }
            set
            {
                this.pidField = value;
            }
        }

        /// <remarks/>
        public string tid
        {
            get
            {
                return this.tidField;
            }
            set
            {
                this.tidField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private XXTransactionResponse xXTransactionResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "xxs")]
        public XXTransactionResponse XXTransactionResponse
        {
            get
            {
                return this.xXTransactionResponseField;
            }
            set
            {
                this.xXTransactionResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "xxs")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "xxs", IsNullable = false)]
    public partial class XXTransactionResponse
    {

        private RSP rSPField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public RSP RSP
        {
            get
            {
                return this.rSPField;
            }
            set
            {
                this.rSPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RSP
    {

        private RSPAirShoppingRS airShoppingRSField;

        /// <remarks/>
        public RSPAirShoppingRS AirShoppingRS
        {
            get
            {
                return this.airShoppingRSField;
            }
            set
            {
                this.airShoppingRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RSPAirShoppingRS
    {

        private RSPAirShoppingRSShoppingResponseID shoppingResponseIDField;

        private decimal versionField;

        private string transactionIdentifierField;

        /// <remarks/>
        public RSPAirShoppingRSShoppingResponseID ShoppingResponseID
        {
            get
            {
                return this.shoppingResponseIDField;
            }
            set
            {
                this.shoppingResponseIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionIdentifier
        {
            get
            {
                return this.transactionIdentifierField;
            }
            set
            {
                this.transactionIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    public partial class RSPAirShoppingRSShoppingResponseID
    {
        /// <remarks/>
        public string Owner { get; set; }

        /// <remarks/>
        public string ResponseID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Source { get; set; }
    }


}

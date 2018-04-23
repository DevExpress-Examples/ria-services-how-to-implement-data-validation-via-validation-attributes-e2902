﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

[assembly: EdmSchemaAttribute()]

namespace Q306524RiaServicesValidation.Web
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TestEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TestEntities object using the connection string found in the 'TestEntities' section of the application configuration file.
        /// </summary>
        public TestEntities() : base("name=TestEntities", "TestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TestEntities object.
        /// </summary>
        public TestEntities(string connectionString) : base(connectionString, "TestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TestEntities object.
        /// </summary>
        public TestEntities(EntityConnection connection) : base(connection, "TestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TestTable> TestTable
        {
            get
            {
                if ((_TestTable == null))
                {
                    _TestTable = base.CreateObjectSet<TestTable>("TestTable");
                }
                return _TestTable;
            }
        }
        private ObjectSet<TestTable> _TestTable;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TestTable EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTestTable(TestTable testTable)
        {
            base.AddObject("TestTable", testTable);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestModel", Name="TestTable")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TestTable : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TestTable object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="number">Initial value of the Number property.</param>
        public static TestTable CreateTestTable(global::System.Guid id, global::System.Int32 number)
        {
            TestTable testTable = new TestTable();
            testTable.ID = id;
            testTable.Number = number;
            return testTable;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        [Range(1, 10)]
        public global::System.Int32 Number
        {
            get
            {
                return _Number;
            }
            set
            {
                OnNumberChanging(value);
                ReportPropertyChanging("Number");
                _Number = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Number");
                OnNumberChanged();
            }
        }
        private global::System.Int32 _Number;
        partial void OnNumberChanging(global::System.Int32 value);
        partial void OnNumberChanged();

        #endregion
    
    }

    #endregion
    
}
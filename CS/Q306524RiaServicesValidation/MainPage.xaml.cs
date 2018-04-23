using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Q306524RiaServicesValidation.Web;
using System.ServiceModel.DomainServices.Client;
using DevExpress.Xpf.Grid;

namespace Q306524RiaServicesValidation {
    public partial class MainPage : UserControl {
        TestDomainContext domainContext = new TestDomainContext();

        public MainPage() {
            InitializeComponent();

            LoadOperation<TestTable> loadOp = domainContext.Load(domainContext.GetTestTableQuery());
            gridControl.ItemsSource = loadOp.Entities;
        }

        void TableView_ValidateRow(object sender, DevExpress.Xpf.Grid.GridRowValidationEventArgs e) {
            TestTable row = e.Row as TestTable;
            if(row.HasValidationErrors) {
                e.IsValid = false;
                e.ErrorContent = "Row cannot be commited.";
            }
        }

        void TableView_InvalidRowException(object sender, DevExpress.Xpf.Grid.InvalidRowExceptionEventArgs e) {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}

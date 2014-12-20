﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Customer))
            {
                return new global::LightSwitchApplication.Implementation.Customer();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Device))
            {
                return new global::LightSwitchApplication.Implementation.Device();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.DeviceStatus))
            {
                return new global::LightSwitchApplication.Implementation.DeviceStatus();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.HwSwOrder))
            {
                return new global::LightSwitchApplication.Implementation.HwSwOrder();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.MakeModel))
            {
                return new global::LightSwitchApplication.Implementation.MakeModel();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.StockLocation))
            {
                return new global::LightSwitchApplication.Implementation.StockLocation();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Customer))
            {
                return new global::LightSwitchApplication.Implementation.Customer();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Device))
            {
                return new global::LightSwitchApplication.Implementation.Device();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.DeviceStatus))
            {
                return new global::LightSwitchApplication.Implementation.DeviceStatus();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.HwSwOrder))
            {
                return new global::LightSwitchApplication.Implementation.HwSwOrder();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.MakeModel))
            {
                return new global::LightSwitchApplication.Implementation.MakeModel();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.StockLocation))
            {
                return new global::LightSwitchApplication.Implementation.StockLocation();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Customer) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Customer);
            }
            if (typeof(global::LightSwitchApplication.Device) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Device);
            }
            if (typeof(global::LightSwitchApplication.DeviceStatus) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.DeviceStatus);
            }
            if (typeof(global::LightSwitchApplication.HwSwOrder) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.HwSwOrder);
            }
            if (typeof(global::LightSwitchApplication.MakeModel) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.MakeModel);
            }
            if (typeof(global::LightSwitchApplication.StockLocation) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.StockLocation);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Customer :
        global::LightSwitchApplication.Customer.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Customer.DetailsClass.IImplementation.Devices
        {
            get
            {
                return this.Devices;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Customer.DetailsClass.IImplementation.HwSwOrders
        {
            get
            {
                return this.HwSwOrders;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Device :
        global::LightSwitchApplication.Device.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Device.DetailsClass.IImplementation.MakeModel
        {
            get
            {
                return this.MakeModel;
            }
            set
            {
                this.MakeModel = (global::LightSwitchApplication.Implementation.MakeModel)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("MakeModel");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Device.DetailsClass.IImplementation.HwSwOrder
        {
            get
            {
                return this.HwSwOrder;
            }
            set
            {
                this.HwSwOrder = (global::LightSwitchApplication.Implementation.HwSwOrder)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("HwSwOrder");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Device.DetailsClass.IImplementation.Owner
        {
            get
            {
                return this.Owner;
            }
            set
            {
                this.Owner = (global::LightSwitchApplication.Implementation.Customer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Owner");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Device.DetailsClass.IImplementation.DeviceStatus
        {
            get
            {
                return this.DeviceStatus;
            }
            set
            {
                this.DeviceStatus = (global::LightSwitchApplication.Implementation.DeviceStatus)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("DeviceStatus");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Device.DetailsClass.IImplementation.StockLocation
        {
            get
            {
                return this.StockLocation;
            }
            set
            {
                this.StockLocation = (global::LightSwitchApplication.Implementation.StockLocation)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("StockLocation");
                }
            }
        }
        
        partial void OnDevice_MakeModelChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("MakeModel");
            }
        }
        
        partial void OnHwSwOrder_DeviceChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("HwSwOrder");
            }
        }
        
        partial void OnDevice_ClientChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Owner");
            }
        }
        
        partial void OnDevice_DeviceStatusChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("DeviceStatus");
            }
        }
        
        partial void OnDevice_StockLocationChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("StockLocation");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class DeviceStatus :
        global::LightSwitchApplication.DeviceStatus.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.DeviceStatus.DetailsClass.IImplementation.Devices
        {
            get
            {
                return this.Devices;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class HwSwOrder :
        global::LightSwitchApplication.HwSwOrder.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.HwSwOrder.DetailsClass.IImplementation.Devices
        {
            get
            {
                return this.Devices;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.HwSwOrder.DetailsClass.IImplementation.Customer
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = (global::LightSwitchApplication.Implementation.Customer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Customer");
                }
            }
        }
        
        partial void OnHwSwOrder_ClientChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Customer");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class MakeModel :
        global::LightSwitchApplication.MakeModel.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.MakeModel.DetailsClass.IImplementation.Devices
        {
            get
            {
                return this.Devices;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class StockLocation :
        global::LightSwitchApplication.StockLocation.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.StockLocation.DetailsClass.IImplementation.Devices
        {
            get
            {
                return this.Devices;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI_ElevenDays.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDTO", Namespace="http://schemas.datacontract.org/2004/07/ElevenDays_Service.DTOS")]
    [System.SerializableAttribute()]
    public partial class UserDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Position", Namespace="http://schemas.datacontract.org/2004/07/PlayerCordons")]
    [System.SerializableAttribute()]
    public partial struct Position : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameInfo", Namespace="http://schemas.datacontract.org/2004/07/ElevenDays_Service")]
    [System.SerializableAttribute()]
    public partial class GameInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UI_ElevenDays.ServiceReference2.PlayerInfo[] PlayersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UI_ElevenDays.ServiceReference2.PlayerInfo[] Players {
            get {
                return this.PlayersField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayersField, value) != true)) {
                    this.PlayersField = value;
                    this.RaisePropertyChanged("Players");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerInfo", Namespace="http://schemas.datacontract.org/2004/07/ElevenDays_Service")]
    [System.SerializableAttribute()]
    public partial class PlayerInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UI_ElevenDays.ServiceReference2.Hitbox HitboxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsImposterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UI_ElevenDays.ServiceReference2.Model ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Player_FruitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DLL_User.User UserField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UI_ElevenDays.ServiceReference2.Hitbox Hitbox {
            get {
                return this.HitboxField;
            }
            set {
                if ((object.ReferenceEquals(this.HitboxField, value) != true)) {
                    this.HitboxField = value;
                    this.RaisePropertyChanged("Hitbox");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsImposter {
            get {
                return this.IsImposterField;
            }
            set {
                if ((this.IsImposterField.Equals(value) != true)) {
                    this.IsImposterField = value;
                    this.RaisePropertyChanged("IsImposter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UI_ElevenDays.ServiceReference2.Model Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Player_Fruit {
            get {
                return this.Player_FruitField;
            }
            set {
                if ((object.ReferenceEquals(this.Player_FruitField, value) != true)) {
                    this.Player_FruitField = value;
                    this.RaisePropertyChanged("Player_Fruit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DLL_User.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hitbox", Namespace="http://schemas.datacontract.org/2004/07/PlayerCordons")]
    [System.SerializableAttribute()]
    public partial class Hitbox : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Model", Namespace="http://schemas.datacontract.org/2004/07/PlayerCordons")]
    [System.SerializableAttribute()]
    public partial class Model : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IElevenDays_GameService")]
    public interface IElevenDays_GameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/Login", ReplyAction="http://tempuri.org/IElevenDays_GameService/LoginResponse")]
        UI_ElevenDays.ServiceReference2.UserDTO Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/Login", ReplyAction="http://tempuri.org/IElevenDays_GameService/LoginResponse")]
        System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.UserDTO> LoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/Register", ReplyAction="http://tempuri.org/IElevenDays_GameService/RegisterResponse")]
        bool Register(string login, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/Register", ReplyAction="http://tempuri.org/IElevenDays_GameService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string login, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/Start", ReplyAction="http://tempuri.org/IElevenDays_GameService/StartResponse")]
        string Start(UI_ElevenDays.ServiceReference2.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/Start", ReplyAction="http://tempuri.org/IElevenDays_GameService/StartResponse")]
        System.Threading.Tasks.Task<string> StartAsync(UI_ElevenDays.ServiceReference2.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/StartByGameID", ReplyAction="http://tempuri.org/IElevenDays_GameService/StartByGameIDResponse")]
        bool StartByGameID(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/StartByGameID", ReplyAction="http://tempuri.org/IElevenDays_GameService/StartByGameIDResponse")]
        System.Threading.Tasks.Task<bool> StartByGameIDAsync(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/End")]
        void End(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/End")]
        System.Threading.Tasks.Task EndAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/Move")]
        void Move(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/Move")]
        System.Threading.Tasks.Task MoveAsync(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetGames", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetGamesResponse")]
        UI_ElevenDays.ServiceReference2.GameInfo[] GetGames(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetGames", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetGamesResponse")]
        System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.GameInfo[]> GetGamesAsync(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/CreateGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/CreateGameResponse")]
        string CreateGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/CreateGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/CreateGameResponse")]
        System.Threading.Tasks.Task<string> CreateGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayersByGameID", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayersByGameIDResponse")]
        UI_ElevenDays.ServiceReference2.PlayerInfo[] GetPlayersByGameID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayersByGameID", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayersByGameIDResponse")]
        System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.PlayerInfo[]> GetPlayersByGameIDAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IElevenDays_GameServiceChannel : UI_ElevenDays.ServiceReference2.IElevenDays_GameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ElevenDays_GameServiceClient : System.ServiceModel.ClientBase<UI_ElevenDays.ServiceReference2.IElevenDays_GameService>, UI_ElevenDays.ServiceReference2.IElevenDays_GameService {
        
        public ElevenDays_GameServiceClient() {
        }
        
        public ElevenDays_GameServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ElevenDays_GameServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ElevenDays_GameServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ElevenDays_GameServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UI_ElevenDays.ServiceReference2.UserDTO Login(string login1, string password) {
            return base.Channel.Login(login1, password);
        }
        
        public System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.UserDTO> LoginAsync(string login, string password) {
            return base.Channel.LoginAsync(login, password);
        }
        
        public bool Register(string login, string email, string password) {
            return base.Channel.Register(login, email, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string login, string email, string password) {
            return base.Channel.RegisterAsync(login, email, password);
        }
        
        public string Start(UI_ElevenDays.ServiceReference2.UserDTO userDTO) {
            return base.Channel.Start(userDTO);
        }
        
        public System.Threading.Tasks.Task<string> StartAsync(UI_ElevenDays.ServiceReference2.UserDTO userDTO) {
            return base.Channel.StartAsync(userDTO);
        }
        
        public bool StartByGameID(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO) {
            return base.Channel.StartByGameID(gameid, userDTO);
        }
        
        public System.Threading.Tasks.Task<bool> StartByGameIDAsync(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO) {
            return base.Channel.StartByGameIDAsync(gameid, userDTO);
        }
        
        public void End(string login) {
            base.Channel.End(login);
        }
        
        public System.Threading.Tasks.Task EndAsync(string login) {
            return base.Channel.EndAsync(login);
        }
        
        public void Move(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer) {
            base.Channel.Move(gameid, login, positionPlayer);
        }
        
        public System.Threading.Tasks.Task MoveAsync(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer) {
            return base.Channel.MoveAsync(gameid, login, positionPlayer);
        }
        
        public UI_ElevenDays.ServiceReference2.GameInfo[] GetGames(int count) {
            return base.Channel.GetGames(count);
        }
        
        public System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.GameInfo[]> GetGamesAsync(int count) {
            return base.Channel.GetGamesAsync(count);
        }
        
        public string CreateGame() {
            return base.Channel.CreateGame();
        }
        
        public System.Threading.Tasks.Task<string> CreateGameAsync() {
            return base.Channel.CreateGameAsync();
        }
        
        public UI_ElevenDays.ServiceReference2.PlayerInfo[] GetPlayersByGameID(string id) {
            return base.Channel.GetPlayersByGameID(id);
        }
        
        public System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.PlayerInfo[]> GetPlayersByGameIDAsync(string id) {
            return base.Channel.GetPlayersByGameIDAsync(id);
        }
    }
}

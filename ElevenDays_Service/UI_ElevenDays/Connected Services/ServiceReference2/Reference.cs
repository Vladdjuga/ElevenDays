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
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double YField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
                }
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
        private string PlayerStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Player_FruitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomField;
        
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
        public string PlayerState {
            get {
                return this.PlayerStateField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerStateField, value) != true)) {
                    this.PlayerStateField = value;
                    this.RaisePropertyChanged("PlayerState");
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
        public string Room {
            get {
                return this.RoomField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomField, value) != true)) {
                    this.RoomField = value;
                    this.RaisePropertyChanged("Room");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IElevenDays_GameService", CallbackContract=typeof(UI_ElevenDays.ServiceReference2.IElevenDays_GameServiceCallback))]
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
        bool StartByGameID(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO, string player_Fruit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/StartByGameID", ReplyAction="http://tempuri.org/IElevenDays_GameService/StartByGameIDResponse")]
        System.Threading.Tasks.Task<bool> StartByGameIDAsync(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO, string player_Fruit);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/End")]
        void End(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/End")]
        System.Threading.Tasks.Task EndAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/Move")]
        void Move(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer, string state, string room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/Move")]
        System.Threading.Tasks.Task MoveAsync(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer, string state, string room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/ChangePlayerState")]
        void ChangePlayerState(string gameid, string login, string currentPlayerState);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/ChangePlayerState")]
        System.Threading.Tasks.Task ChangePlayerStateAsync(string gameid, string login, string currentPlayerState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetGameResponse")]
        UI_ElevenDays.ServiceReference2.GameInfo GetGame(int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetGameResponse")]
        System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.GameInfo> GetGameAsync(int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetGamesCount", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetGamesCountResponse")]
        int GetGamesCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetGamesCount", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetGamesCountResponse")]
        System.Threading.Tasks.Task<int> GetGamesCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayersCount", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayersCountResponse")]
        int GetPlayersCount(string game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayersCount", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayersCountResponse")]
        System.Threading.Tasks.Task<int> GetPlayersCountAsync(string game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayer", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerResponse")]
        UI_ElevenDays.ServiceReference2.PlayerInfo GetPlayer(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayer", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerResponse")]
        System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.PlayerInfo> GetPlayerAsync(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayerString", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerStringResponse")]
        string GetPlayerString(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayerString", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerStringResponse")]
        System.Threading.Tasks.Task<string> GetPlayerStringAsync(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayerFruit", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerFruitResponse")]
        string GetPlayerFruit(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayerFruit", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerFruitResponse")]
        System.Threading.Tasks.Task<string> GetPlayerFruitAsync(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayerPosition", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerPositionResponse")]
        UI_ElevenDays.ServiceReference2.Position GetPlayerPosition(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/GetPlayerPosition", ReplyAction="http://tempuri.org/IElevenDays_GameService/GetPlayerPositionResponse")]
        System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.Position> GetPlayerPositionAsync(string game, int ind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/CreateGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/CreateGameResponse")]
        string CreateGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/CreateGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/CreateGameResponse")]
        System.Threading.Tasks.Task<string> CreateGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/FindGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/FindGameResponse")]
        string FindGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/FindGame", ReplyAction="http://tempuri.org/IElevenDays_GameService/FindGameResponse")]
        System.Threading.Tasks.Task<string> FindGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/FindGameById", ReplyAction="http://tempuri.org/IElevenDays_GameService/FindGameByIdResponse")]
        string FindGameById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/FindGameById", ReplyAction="http://tempuri.org/IElevenDays_GameService/FindGameByIdResponse")]
        System.Threading.Tasks.Task<string> FindGameByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/IsAnyWithFruit", ReplyAction="http://tempuri.org/IElevenDays_GameService/IsAnyWithFruitResponse")]
        bool IsAnyWithFruit(string game, string fruit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IElevenDays_GameService/IsAnyWithFruit", ReplyAction="http://tempuri.org/IElevenDays_GameService/IsAnyWithFruitResponse")]
        System.Threading.Tasks.Task<bool> IsAnyWithFruitAsync(string game, string fruit);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IElevenDays_GameServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/GetMove")]
        void GetMove(UI_ElevenDays.ServiceReference2.Position position, string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/GetState")]
        void GetState(string state, string login, string character);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/GetNewPlayerArrived")]
        void GetNewPlayerArrived(UI_ElevenDays.ServiceReference2.Position position, string login, string character, string room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/GetDisconected")]
        void GetDisconected(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IElevenDays_GameService/GetPlayerChangedRoom")]
        void GetPlayerChangedRoom(string login, string room);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IElevenDays_GameServiceChannel : UI_ElevenDays.ServiceReference2.IElevenDays_GameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ElevenDays_GameServiceClient : System.ServiceModel.DuplexClientBase<UI_ElevenDays.ServiceReference2.IElevenDays_GameService>, UI_ElevenDays.ServiceReference2.IElevenDays_GameService {
        
        public ElevenDays_GameServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ElevenDays_GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ElevenDays_GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ElevenDays_GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ElevenDays_GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
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
        
        public bool StartByGameID(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO, string player_Fruit) {
            return base.Channel.StartByGameID(gameid, userDTO, player_Fruit);
        }
        
        public System.Threading.Tasks.Task<bool> StartByGameIDAsync(string gameid, UI_ElevenDays.ServiceReference2.UserDTO userDTO, string player_Fruit) {
            return base.Channel.StartByGameIDAsync(gameid, userDTO, player_Fruit);
        }
        
        public void End(string login) {
            base.Channel.End(login);
        }
        
        public System.Threading.Tasks.Task EndAsync(string login) {
            return base.Channel.EndAsync(login);
        }
        
        public void Move(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer, string state, string room) {
            base.Channel.Move(gameid, login, positionPlayer, state, room);
        }
        
        public System.Threading.Tasks.Task MoveAsync(string gameid, string login, UI_ElevenDays.ServiceReference2.Position positionPlayer, string state, string room) {
            return base.Channel.MoveAsync(gameid, login, positionPlayer, state, room);
        }
        
        public void ChangePlayerState(string gameid, string login, string currentPlayerState) {
            base.Channel.ChangePlayerState(gameid, login, currentPlayerState);
        }
        
        public System.Threading.Tasks.Task ChangePlayerStateAsync(string gameid, string login, string currentPlayerState) {
            return base.Channel.ChangePlayerStateAsync(gameid, login, currentPlayerState);
        }
        
        public UI_ElevenDays.ServiceReference2.GameInfo GetGame(int ind) {
            return base.Channel.GetGame(ind);
        }
        
        public System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.GameInfo> GetGameAsync(int ind) {
            return base.Channel.GetGameAsync(ind);
        }
        
        public int GetGamesCount() {
            return base.Channel.GetGamesCount();
        }
        
        public System.Threading.Tasks.Task<int> GetGamesCountAsync() {
            return base.Channel.GetGamesCountAsync();
        }
        
        public int GetPlayersCount(string game) {
            return base.Channel.GetPlayersCount(game);
        }
        
        public System.Threading.Tasks.Task<int> GetPlayersCountAsync(string game) {
            return base.Channel.GetPlayersCountAsync(game);
        }
        
        public UI_ElevenDays.ServiceReference2.PlayerInfo GetPlayer(string game, int ind) {
            return base.Channel.GetPlayer(game, ind);
        }
        
        public System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.PlayerInfo> GetPlayerAsync(string game, int ind) {
            return base.Channel.GetPlayerAsync(game, ind);
        }
        
        public string GetPlayerString(string game, int ind) {
            return base.Channel.GetPlayerString(game, ind);
        }
        
        public System.Threading.Tasks.Task<string> GetPlayerStringAsync(string game, int ind) {
            return base.Channel.GetPlayerStringAsync(game, ind);
        }
        
        public string GetPlayerFruit(string game, int ind) {
            return base.Channel.GetPlayerFruit(game, ind);
        }
        
        public System.Threading.Tasks.Task<string> GetPlayerFruitAsync(string game, int ind) {
            return base.Channel.GetPlayerFruitAsync(game, ind);
        }
        
        public UI_ElevenDays.ServiceReference2.Position GetPlayerPosition(string game, int ind) {
            return base.Channel.GetPlayerPosition(game, ind);
        }
        
        public System.Threading.Tasks.Task<UI_ElevenDays.ServiceReference2.Position> GetPlayerPositionAsync(string game, int ind) {
            return base.Channel.GetPlayerPositionAsync(game, ind);
        }
        
        public string CreateGame() {
            return base.Channel.CreateGame();
        }
        
        public System.Threading.Tasks.Task<string> CreateGameAsync() {
            return base.Channel.CreateGameAsync();
        }
        
        public string FindGame() {
            return base.Channel.FindGame();
        }
        
        public System.Threading.Tasks.Task<string> FindGameAsync() {
            return base.Channel.FindGameAsync();
        }
        
        public string FindGameById(string id) {
            return base.Channel.FindGameById(id);
        }
        
        public System.Threading.Tasks.Task<string> FindGameByIdAsync(string id) {
            return base.Channel.FindGameByIdAsync(id);
        }
        
        public bool IsAnyWithFruit(string game, string fruit) {
            return base.Channel.IsAnyWithFruit(game, fruit);
        }
        
        public System.Threading.Tasks.Task<bool> IsAnyWithFruitAsync(string game, string fruit) {
            return base.Channel.IsAnyWithFruitAsync(game, fruit);
        }
    }
}

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UnityEngine;
using UniRx;


public partial class MainMenuRootViewModelBase : uFrame.MVVM.ViewModel {
    
    private P<Type> _CurrentScreenTypeProperty;
    
    private ModelCollection<SubScreenViewModel> _Screens;
    
    public MainMenuRootViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<Type> CurrentScreenTypeProperty {
        get {
            return _CurrentScreenTypeProperty;
        }
        set {
            _CurrentScreenTypeProperty = value;
        }
    }
    
    public virtual Type CurrentScreenType {
        get {
            return CurrentScreenTypeProperty.Value;
        }
        set {
            CurrentScreenTypeProperty.Value = value;
        }
    }
    
    public virtual ModelCollection<SubScreenViewModel> Screens {
        get {
            return _Screens;
        }
        set {
            _Screens = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        _CurrentScreenTypeProperty = new P<Type>(this, "CurrentScreenType");
        _Screens = new ModelCollection<SubScreenViewModel>(this, "Screens");
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
        if (stream.DeepSerialize) {
            this.Screens.Clear();
            this.Screens.AddRange(stream.DeserializeObjectArray<SubScreenViewModel>("Screens"));
        }
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
        if (stream.DeepSerialize) stream.SerializeArray("Screens", this.Screens);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_CurrentScreenTypeProperty, false, false, false, false));
        list.Add(new ViewModelPropertyInfo(_Screens, true, true, false, false));
    }
}

public partial class MainMenuRootViewModel {
    
    public MainMenuRootViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class SubScreenViewModelBase : uFrame.MVVM.ViewModel {
    
    private P<Boolean> _IsActiveProperty;
    
    private Signal<CloseCommand> _Close;
    
    public SubScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<Boolean> IsActiveProperty {
        get {
            return _IsActiveProperty;
        }
        set {
            _IsActiveProperty = value;
        }
    }
    
    public virtual Boolean IsActive {
        get {
            return IsActiveProperty.Value;
        }
        set {
            IsActiveProperty.Value = value;
        }
    }
    
    public virtual Signal<CloseCommand> Close {
        get {
            return _Close;
        }
        set {
            _Close = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        this.Close = new Signal<CloseCommand>(this);
        _IsActiveProperty = new P<Boolean>(this, "IsActive");
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
        this.IsActive = stream.DeserializeBool("IsActive");;
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
        stream.SerializeBool("IsActive", this.IsActive);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
        list.Add(new ViewModelCommandInfo("Close", Close) { ParameterType = typeof(void) });
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_IsActiveProperty, false, false, false, false));
    }
}

public partial class SubScreenViewModel {
    
    public SubScreenViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class LoginScreenViewModelBase : SubScreenViewModel {
    
    private P<String> _UsernameProperty;
    
    private P<String> _PasswordProperty;
    
    private Signal<LoginCommand> _Login;
    
    public LoginScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<String> UsernameProperty {
        get {
            return _UsernameProperty;
        }
        set {
            _UsernameProperty = value;
        }
    }
    
    public virtual P<String> PasswordProperty {
        get {
            return _PasswordProperty;
        }
        set {
            _PasswordProperty = value;
        }
    }
    
    public virtual String Username {
        get {
            return UsernameProperty.Value;
        }
        set {
            UsernameProperty.Value = value;
        }
    }
    
    public virtual String Password {
        get {
            return PasswordProperty.Value;
        }
        set {
            PasswordProperty.Value = value;
        }
    }
    
    public virtual Signal<LoginCommand> Login {
        get {
            return _Login;
        }
        set {
            _Login = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        this.Login = new Signal<LoginCommand>(this);
        _UsernameProperty = new P<String>(this, "Username");
        _PasswordProperty = new P<String>(this, "Password");
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
        list.Add(new ViewModelCommandInfo("Login", Login) { ParameterType = typeof(void) });
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_UsernameProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_PasswordProperty, false, false, false, false));
    }
}

public partial class LoginScreenViewModel {
    
    public LoginScreenViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class SettingsScreenViewModelBase : SubScreenViewModel {
    
    private P<ResolutionInformation> _ResolutionProperty;
    
    private P<Single> _VolumeProperty;
    
    private ModelCollection<ResolutionInformation> _AvailableResolutions;
    
    private Signal<ApplyCommand> _Apply;
    
    private Signal<DefaultCommand> _Default;
    
    public SettingsScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<ResolutionInformation> ResolutionProperty {
        get {
            return _ResolutionProperty;
        }
        set {
            _ResolutionProperty = value;
        }
    }
    
    public virtual P<Single> VolumeProperty {
        get {
            return _VolumeProperty;
        }
        set {
            _VolumeProperty = value;
        }
    }
    
    public virtual ResolutionInformation Resolution {
        get {
            return ResolutionProperty.Value;
        }
        set {
            ResolutionProperty.Value = value;
        }
    }
    
    public virtual Single Volume {
        get {
            return VolumeProperty.Value;
        }
        set {
            VolumeProperty.Value = value;
        }
    }
    
    public virtual ModelCollection<ResolutionInformation> AvailableResolutions {
        get {
            return _AvailableResolutions;
        }
        set {
            _AvailableResolutions = value;
        }
    }
    
    public virtual Signal<ApplyCommand> Apply {
        get {
            return _Apply;
        }
        set {
            _Apply = value;
        }
    }
    
    public virtual Signal<DefaultCommand> Default {
        get {
            return _Default;
        }
        set {
            _Default = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        this.Apply = new Signal<ApplyCommand>(this);
        this.Default = new Signal<DefaultCommand>(this);
        _ResolutionProperty = new P<ResolutionInformation>(this, "Resolution");
        _VolumeProperty = new P<Single>(this, "Volume");
        _AvailableResolutions = new ModelCollection<ResolutionInformation>(this, "AvailableResolutions");
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
        this.Volume = stream.DeserializeFloat("Volume");;
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
        stream.SerializeFloat("Volume", this.Volume);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
        list.Add(new ViewModelCommandInfo("Apply", Apply) { ParameterType = typeof(void) });
        list.Add(new ViewModelCommandInfo("Default", Default) { ParameterType = typeof(void) });
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_ResolutionProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_VolumeProperty, false, false, false, false));
        list.Add(new ViewModelPropertyInfo(_AvailableResolutions, false, true, false, false));
    }
}

public partial class SettingsScreenViewModel {
    
    public SettingsScreenViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class LevelSelectScreenViewModelBase : SubScreenViewModel {
    
    private ModelCollection<LevelDescriptor> _AvailableLevels;
    
    private Signal<SelectLevelCommand> _SelectLevel;
    
    public LevelSelectScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual ModelCollection<LevelDescriptor> AvailableLevels {
        get {
            return _AvailableLevels;
        }
        set {
            _AvailableLevels = value;
        }
    }
    
    public virtual Signal<SelectLevelCommand> SelectLevel {
        get {
            return _SelectLevel;
        }
        set {
            _SelectLevel = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        this.SelectLevel = new Signal<SelectLevelCommand>(this);
        _AvailableLevels = new ModelCollection<LevelDescriptor>(this, "AvailableLevels");
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
        list.Add(new ViewModelCommandInfo("SelectLevel", SelectLevel) { ParameterType = typeof(LevelDescriptor) });
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        list.Add(new ViewModelPropertyInfo(_AvailableLevels, false, true, false, false));
    }
}

public partial class LevelSelectScreenViewModel {
    
    public LevelSelectScreenViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class MenuScreenViewModelBase : SubScreenViewModel {
    
    public MenuScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
    }
}

public partial class MenuScreenViewModel {
    
    public MenuScreenViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class NoticeScreenViewModelBase : SubScreenViewModel {
    
    public NoticeScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
    }
}

public partial class NoticeScreenViewModel {
    
    public NoticeScreenViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

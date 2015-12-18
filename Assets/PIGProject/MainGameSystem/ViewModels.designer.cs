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


public partial class MainGameRootViewModelBase : uFrame.MVVM.ViewModel {
    
    private P<String> _StateProperty;
    
    private P<String> _HexGridMatchingProperty;
    
    private ModelCollection<String> _Soldier;
    
    private ModelCollection<String> _Enemy;
    
    private ModelCollection<EntityViewModel> _Memebers;
    
    private Signal<GoToMenuCommand> _GoToMenu;
    
    private Signal<PlayCommand> _Play;
    
    private Signal<GameOverCommand> _GameOver;
    
    public MainGameRootViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<String> StateProperty {
        get {
            return _StateProperty;
        }
        set {
            _StateProperty = value;
        }
    }
    
    public virtual P<String> HexGridMatchingProperty {
        get {
            return _HexGridMatchingProperty;
        }
        set {
            _HexGridMatchingProperty = value;
        }
    }
    
    public virtual String State {
        get {
            return StateProperty.Value;
        }
        set {
            StateProperty.Value = value;
        }
    }
    
    public virtual String HexGridMatching {
        get {
            return HexGridMatchingProperty.Value;
        }
        set {
            HexGridMatchingProperty.Value = value;
        }
    }
    
    public virtual ModelCollection<String> Soldier {
        get {
            return _Soldier;
        }
        set {
            _Soldier = value;
        }
    }
    
    public virtual ModelCollection<String> Enemy {
        get {
            return _Enemy;
        }
        set {
            _Enemy = value;
        }
    }
    
    public virtual ModelCollection<EntityViewModel> Memebers {
        get {
            return _Memebers;
        }
        set {
            _Memebers = value;
        }
    }
    
    public virtual Signal<GoToMenuCommand> GoToMenu {
        get {
            return _GoToMenu;
        }
        set {
            _GoToMenu = value;
        }
    }
    
    public virtual Signal<PlayCommand> Play {
        get {
            return _Play;
        }
        set {
            _Play = value;
        }
    }
    
    public virtual Signal<GameOverCommand> GameOver {
        get {
            return _GameOver;
        }
        set {
            _GameOver = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        this.GoToMenu = new Signal<GoToMenuCommand>(this);
        this.Play = new Signal<PlayCommand>(this);
        this.GameOver = new Signal<GameOverCommand>(this);
        _StateProperty = new P<String>(this, "State");
        _HexGridMatchingProperty = new P<String>(this, "HexGridMatching");
        _Soldier = new ModelCollection<String>(this, "Soldier");
        _Enemy = new ModelCollection<String>(this, "Enemy");
        _Memebers = new ModelCollection<EntityViewModel>(this, "Memebers");
    }
    
    public virtual void ExecuteGoToMenu() {
        this.GoToMenu.OnNext(new GoToMenuCommand());
    }
    
    public virtual void ExecutePlay() {
        this.Play.OnNext(new PlayCommand());
    }
    
    public virtual void ExecuteGameOver() {
        this.GameOver.OnNext(new GameOverCommand());
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
        this.State = stream.DeserializeString("State");;
        this.HexGridMatching = stream.DeserializeString("HexGridMatching");;
        if (stream.DeepSerialize) {
            this.Memebers.Clear();
            this.Memebers.AddRange(stream.DeserializeObjectArray<EntityViewModel>("Memebers"));
        }
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
        stream.SerializeString("State", this.State);
        stream.SerializeString("HexGridMatching", this.HexGridMatching);
        if (stream.DeepSerialize) stream.SerializeArray("Memebers", this.Memebers);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
        list.Add(new ViewModelCommandInfo("GoToMenu", GoToMenu) { ParameterType = typeof(void) });
        list.Add(new ViewModelCommandInfo("Play", Play) { ParameterType = typeof(void) });
        list.Add(new ViewModelCommandInfo("GameOver", GameOver) { ParameterType = typeof(void) });
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_StateProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_HexGridMatchingProperty, false, false, false, false));
        list.Add(new ViewModelPropertyInfo(_Soldier, false, true, false, false));
        list.Add(new ViewModelPropertyInfo(_Enemy, false, true, false, false));
        list.Add(new ViewModelPropertyInfo(_Memebers, true, true, false, false));
    }
}

public partial class MainGameRootViewModel {
    
    public MainGameRootViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class SoldierViewModelBase : EntityViewModel {
    
    private P<SoldierState> _SoldierStateProperty;
    
    private ModelCollection<Int32> _HealthHistory;
    
    private Signal<ChangeActionStyleCommand> _ChangeActionStyle;
    
    public SoldierViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<SoldierState> SoldierStateProperty {
        get {
            return _SoldierStateProperty;
        }
        set {
            _SoldierStateProperty = value;
        }
    }
    
    public virtual SoldierState SoldierState {
        get {
            return SoldierStateProperty.Value;
        }
        set {
            SoldierStateProperty.Value = value;
        }
    }
    
    public virtual ModelCollection<Int32> HealthHistory {
        get {
            return _HealthHistory;
        }
        set {
            _HealthHistory = value;
        }
    }
    
    public virtual Signal<ChangeActionStyleCommand> ChangeActionStyle {
        get {
            return _ChangeActionStyle;
        }
        set {
            _ChangeActionStyle = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        this.ChangeActionStyle = new Signal<ChangeActionStyleCommand>(this);
        _SoldierStateProperty = new P<SoldierState>(this, "SoldierState");
        _HealthHistory = new ModelCollection<Int32>(this, "HealthHistory");
    }
    
    public virtual void ExecuteChangeActionStyle() {
        this.ChangeActionStyle.OnNext(new ChangeActionStyleCommand());
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
        this.SoldierState = (SoldierState)stream.DeserializeInt("SoldierState");;
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
        stream.SerializeInt("SoldierState", (int)this.SoldierState);;
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
        list.Add(new ViewModelCommandInfo("ChangeActionStyle", ChangeActionStyle) { ParameterType = typeof(void) });
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_SoldierStateProperty, false, false, true, false));
        list.Add(new ViewModelPropertyInfo(_HealthHistory, false, true, false, false));
    }
}

public partial class SoldierViewModel {
    
    public SoldierViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class EnemyViewModelBase : EntityViewModel {
    
    public EnemyViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
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

public partial class EnemyViewModel {
    
    public EnemyViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

public partial class EntityViewModelBase : uFrame.MVVM.ViewModel {
    
    private P<Single> _HealthProperty;
    
    private P<Single> _Max_HealthProperty;
    
    private P<Int32> _AttackSpeedProperty;
    
    private P<MoveStyle> _MovementProperty;
    
    private P<Int32> _PowerProperty;
    
    private P<Boolean> _isAttackProperty;
    
    private P<ActionStyle> _ActionProperty;
    
    private P<Int32> _MAXROUNDSProperty;
    
    private P<String> _NameProperty;
    
    private P<Single> _PhysiqueProperty;
    
    private P<Int32> _HitPointProperty;
    
    private P<Int32> _WeaponProficienyProperty;
    
    private P<Single> _DodgeProperty;
    
    private P<Single> _HurtProperty;
    
    private P<Single> _DeadProperty;
    
    private P<Int32> _InitialMoraleProperty;
    
    private P<Int32> _PrestigeProperty;
    
    private P<Boolean> _DEBUGProperty;
    
    private P<Int32> _counterProperty;
    
    private P<Int32> _CounterProperty;
    
    private P<Int32> _UpdatePerRoundProperty;
    
    private P<Int32> _ElementsPerSecondProperty;
    
    private P<Int32> _WarTimeLimitInSecondProperty;
    
    private P<Single> _starttimeProperty;
    
    private P<Boolean> _TimeStartedProperty;
    
    private P<Int32> _WeaponProficiencyProperty;
    
    private P<Int32> _moraleStandardProperty;
    
    private P<EntityViewModel> _OpponentProperty;
    
    private P<BattleState> _BattleStateProperty;
    
    private P<PlayList> _PlayListProperty;
    
    private P<Career> _CareerProperty;
    
    private P<Boolean> _MovingProperty;
    
    public EntityViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<Single> HealthProperty {
        get {
            return _HealthProperty;
        }
        set {
            _HealthProperty = value;
        }
    }
    
    public virtual P<Single> Max_HealthProperty {
        get {
            return _Max_HealthProperty;
        }
        set {
            _Max_HealthProperty = value;
        }
    }
    
    public virtual P<Int32> AttackSpeedProperty {
        get {
            return _AttackSpeedProperty;
        }
        set {
            _AttackSpeedProperty = value;
        }
    }
    
    public virtual P<MoveStyle> MovementProperty {
        get {
            return _MovementProperty;
        }
        set {
            _MovementProperty = value;
        }
    }
    
    public virtual P<Int32> PowerProperty {
        get {
            return _PowerProperty;
        }
        set {
            _PowerProperty = value;
        }
    }
    
    public virtual P<Boolean> isAttackProperty {
        get {
            return _isAttackProperty;
        }
        set {
            _isAttackProperty = value;
        }
    }
    
    public virtual P<ActionStyle> ActionProperty {
        get {
            return _ActionProperty;
        }
        set {
            _ActionProperty = value;
        }
    }
    
    public virtual P<Int32> MAXROUNDSProperty {
        get {
            return _MAXROUNDSProperty;
        }
        set {
            _MAXROUNDSProperty = value;
        }
    }
    
    public virtual P<String> NameProperty {
        get {
            return _NameProperty;
        }
        set {
            _NameProperty = value;
        }
    }
    
    public virtual P<Single> PhysiqueProperty {
        get {
            return _PhysiqueProperty;
        }
        set {
            _PhysiqueProperty = value;
        }
    }
    
    public virtual P<Int32> HitPointProperty {
        get {
            return _HitPointProperty;
        }
        set {
            _HitPointProperty = value;
        }
    }
    
    public virtual P<Int32> WeaponProficienyProperty {
        get {
            return _WeaponProficienyProperty;
        }
        set {
            _WeaponProficienyProperty = value;
        }
    }
    
    public virtual P<Single> DodgeProperty {
        get {
            return _DodgeProperty;
        }
        set {
            _DodgeProperty = value;
        }
    }
    
    public virtual P<Single> HurtProperty {
        get {
            return _HurtProperty;
        }
        set {
            _HurtProperty = value;
        }
    }
    
    public virtual P<Single> DeadProperty {
        get {
            return _DeadProperty;
        }
        set {
            _DeadProperty = value;
        }
    }
    
    public virtual P<Int32> InitialMoraleProperty {
        get {
            return _InitialMoraleProperty;
        }
        set {
            _InitialMoraleProperty = value;
        }
    }
    
    public virtual P<Int32> PrestigeProperty {
        get {
            return _PrestigeProperty;
        }
        set {
            _PrestigeProperty = value;
        }
    }
    
    public virtual P<Boolean> DEBUGProperty {
        get {
            return _DEBUGProperty;
        }
        set {
            _DEBUGProperty = value;
        }
    }
    
    public virtual P<Int32> counterProperty {
        get {
            return _counterProperty;
        }
        set {
            _counterProperty = value;
        }
    }
    
    public virtual P<Int32> CounterProperty {
        get {
            return _CounterProperty;
        }
        set {
            _CounterProperty = value;
        }
    }
    
    public virtual P<Int32> UpdatePerRoundProperty {
        get {
            return _UpdatePerRoundProperty;
        }
        set {
            _UpdatePerRoundProperty = value;
        }
    }
    
    public virtual P<Int32> ElementsPerSecondProperty {
        get {
            return _ElementsPerSecondProperty;
        }
        set {
            _ElementsPerSecondProperty = value;
        }
    }
    
    public virtual P<Int32> WarTimeLimitInSecondProperty {
        get {
            return _WarTimeLimitInSecondProperty;
        }
        set {
            _WarTimeLimitInSecondProperty = value;
        }
    }
    
    public virtual P<Single> starttimeProperty {
        get {
            return _starttimeProperty;
        }
        set {
            _starttimeProperty = value;
        }
    }
    
    public virtual P<Boolean> TimeStartedProperty {
        get {
            return _TimeStartedProperty;
        }
        set {
            _TimeStartedProperty = value;
        }
    }
    
    public virtual P<Int32> WeaponProficiencyProperty {
        get {
            return _WeaponProficiencyProperty;
        }
        set {
            _WeaponProficiencyProperty = value;
        }
    }
    
    public virtual P<Int32> moraleStandardProperty {
        get {
            return _moraleStandardProperty;
        }
        set {
            _moraleStandardProperty = value;
        }
    }
    
    public virtual P<EntityViewModel> OpponentProperty {
        get {
            return _OpponentProperty;
        }
        set {
            _OpponentProperty = value;
        }
    }
    
    public virtual P<BattleState> BattleStateProperty {
        get {
            return _BattleStateProperty;
        }
        set {
            _BattleStateProperty = value;
        }
    }
    
    public virtual P<PlayList> PlayListProperty {
        get {
            return _PlayListProperty;
        }
        set {
            _PlayListProperty = value;
        }
    }
    
    public virtual P<Career> CareerProperty {
        get {
            return _CareerProperty;
        }
        set {
            _CareerProperty = value;
        }
    }
    
    public virtual P<Boolean> MovingProperty {
        get {
            return _MovingProperty;
        }
        set {
            _MovingProperty = value;
        }
    }
    
    public virtual Single Health {
        get {
            return HealthProperty.Value;
        }
        set {
            HealthProperty.Value = value;
        }
    }
    
    public virtual Single Max_Health {
        get {
            return Max_HealthProperty.Value;
        }
        set {
            Max_HealthProperty.Value = value;
        }
    }
    
    public virtual Int32 AttackSpeed {
        get {
            return AttackSpeedProperty.Value;
        }
        set {
            AttackSpeedProperty.Value = value;
        }
    }
    
    public virtual MoveStyle Movement {
        get {
            return MovementProperty.Value;
        }
        set {
            MovementProperty.Value = value;
        }
    }
    
    public virtual Int32 Power {
        get {
            return PowerProperty.Value;
        }
        set {
            PowerProperty.Value = value;
        }
    }
    
    public virtual Boolean isAttack {
        get {
            return isAttackProperty.Value;
        }
        set {
            isAttackProperty.Value = value;
        }
    }
    
    public virtual ActionStyle Action {
        get {
            return ActionProperty.Value;
        }
        set {
            ActionProperty.Value = value;
        }
    }
    
    public virtual Int32 MAXROUNDS {
        get {
            return MAXROUNDSProperty.Value;
        }
        set {
            MAXROUNDSProperty.Value = value;
        }
    }
    
    public virtual String Name {
        get {
            return NameProperty.Value;
        }
        set {
            NameProperty.Value = value;
        }
    }
    
    public virtual Single Physique {
        get {
            return PhysiqueProperty.Value;
        }
        set {
            PhysiqueProperty.Value = value;
        }
    }
    
    public virtual Int32 HitPoint {
        get {
            return HitPointProperty.Value;
        }
        set {
            HitPointProperty.Value = value;
        }
    }
    
    public virtual Int32 WeaponProficieny {
        get {
            return WeaponProficienyProperty.Value;
        }
        set {
            WeaponProficienyProperty.Value = value;
        }
    }
    
    public virtual Single Dodge {
        get {
            return DodgeProperty.Value;
        }
        set {
            DodgeProperty.Value = value;
        }
    }
    
    public virtual Single Hurt {
        get {
            return HurtProperty.Value;
        }
        set {
            HurtProperty.Value = value;
        }
    }
    
    public virtual Single Dead {
        get {
            return DeadProperty.Value;
        }
        set {
            DeadProperty.Value = value;
        }
    }
    
    public virtual Int32 InitialMorale {
        get {
            return InitialMoraleProperty.Value;
        }
        set {
            InitialMoraleProperty.Value = value;
        }
    }
    
    public virtual Int32 Prestige {
        get {
            return PrestigeProperty.Value;
        }
        set {
            PrestigeProperty.Value = value;
        }
    }
    
    public virtual Boolean DEBUG {
        get {
            return DEBUGProperty.Value;
        }
        set {
            DEBUGProperty.Value = value;
        }
    }
    
    public virtual Int32 counter {
        get {
            return counterProperty.Value;
        }
        set {
            counterProperty.Value = value;
        }
    }
    
    public virtual Int32 Counter {
        get {
            return CounterProperty.Value;
        }
        set {
            CounterProperty.Value = value;
        }
    }
    
    public virtual Int32 UpdatePerRound {
        get {
            return UpdatePerRoundProperty.Value;
        }
        set {
            UpdatePerRoundProperty.Value = value;
        }
    }
    
    public virtual Int32 ElementsPerSecond {
        get {
            return ElementsPerSecondProperty.Value;
        }
        set {
            ElementsPerSecondProperty.Value = value;
        }
    }
    
    public virtual Int32 WarTimeLimitInSecond {
        get {
            return WarTimeLimitInSecondProperty.Value;
        }
        set {
            WarTimeLimitInSecondProperty.Value = value;
        }
    }
    
    public virtual Single starttime {
        get {
            return starttimeProperty.Value;
        }
        set {
            starttimeProperty.Value = value;
        }
    }
    
    public virtual Boolean TimeStarted {
        get {
            return TimeStartedProperty.Value;
        }
        set {
            TimeStartedProperty.Value = value;
        }
    }
    
    public virtual Int32 WeaponProficiency {
        get {
            return WeaponProficiencyProperty.Value;
        }
        set {
            WeaponProficiencyProperty.Value = value;
        }
    }
    
    public virtual Int32 moraleStandard {
        get {
            return moraleStandardProperty.Value;
        }
        set {
            moraleStandardProperty.Value = value;
        }
    }
    
    public virtual EntityViewModel Opponent {
        get {
            return OpponentProperty.Value;
        }
        set {
            OpponentProperty.Value = value;
        }
    }
    
    public virtual BattleState BattleState {
        get {
            return BattleStateProperty.Value;
        }
        set {
            BattleStateProperty.Value = value;
        }
    }
    
    public virtual PlayList PlayList {
        get {
            return PlayListProperty.Value;
        }
        set {
            PlayListProperty.Value = value;
        }
    }
    
    public virtual Career Career {
        get {
            return CareerProperty.Value;
        }
        set {
            CareerProperty.Value = value;
        }
    }
    
    public virtual Boolean Moving {
        get {
            return MovingProperty.Value;
        }
        set {
            MovingProperty.Value = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        _HealthProperty = new P<Single>(this, "Health");
        _Max_HealthProperty = new P<Single>(this, "Max_Health");
        _AttackSpeedProperty = new P<Int32>(this, "AttackSpeed");
        _MovementProperty = new P<MoveStyle>(this, "Movement");
        _PowerProperty = new P<Int32>(this, "Power");
        _isAttackProperty = new P<Boolean>(this, "isAttack");
        _ActionProperty = new P<ActionStyle>(this, "Action");
        _MAXROUNDSProperty = new P<Int32>(this, "MAXROUNDS");
        _NameProperty = new P<String>(this, "Name");
        _PhysiqueProperty = new P<Single>(this, "Physique");
        _HitPointProperty = new P<Int32>(this, "HitPoint");
        _WeaponProficienyProperty = new P<Int32>(this, "WeaponProficieny");
        _DodgeProperty = new P<Single>(this, "Dodge");
        _HurtProperty = new P<Single>(this, "Hurt");
        _DeadProperty = new P<Single>(this, "Dead");
        _InitialMoraleProperty = new P<Int32>(this, "InitialMorale");
        _PrestigeProperty = new P<Int32>(this, "Prestige");
        _DEBUGProperty = new P<Boolean>(this, "DEBUG");
        _counterProperty = new P<Int32>(this, "counter");
        _CounterProperty = new P<Int32>(this, "Counter");
        _UpdatePerRoundProperty = new P<Int32>(this, "UpdatePerRound");
        _ElementsPerSecondProperty = new P<Int32>(this, "ElementsPerSecond");
        _WarTimeLimitInSecondProperty = new P<Int32>(this, "WarTimeLimitInSecond");
        _starttimeProperty = new P<Single>(this, "starttime");
        _TimeStartedProperty = new P<Boolean>(this, "TimeStarted");
        _WeaponProficiencyProperty = new P<Int32>(this, "WeaponProficiency");
        _moraleStandardProperty = new P<Int32>(this, "moraleStandard");
        _OpponentProperty = new P<EntityViewModel>(this, "Opponent");
        _BattleStateProperty = new P<BattleState>(this, "BattleState");
        _PlayListProperty = new P<PlayList>(this, "PlayList");
        _CareerProperty = new P<Career>(this, "Career");
        _MovingProperty = new P<Boolean>(this, "Moving");
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
        this.Health = stream.DeserializeFloat("Health");;
        this.Max_Health = stream.DeserializeFloat("Max_Health");;
        this.AttackSpeed = stream.DeserializeInt("AttackSpeed");;
        this.Movement = (MoveStyle)stream.DeserializeInt("Movement");;
        this.Power = stream.DeserializeInt("Power");;
        this.isAttack = stream.DeserializeBool("isAttack");;
        this.Action = (ActionStyle)stream.DeserializeInt("Action");;
        this.MAXROUNDS = stream.DeserializeInt("MAXROUNDS");;
        this.Physique = stream.DeserializeFloat("Physique");;
        this.HitPoint = stream.DeserializeInt("HitPoint");;
        this.WeaponProficieny = stream.DeserializeInt("WeaponProficieny");;
        this.Dodge = stream.DeserializeFloat("Dodge");;
        this.Hurt = stream.DeserializeFloat("Hurt");;
        this.Dead = stream.DeserializeFloat("Dead");;
        this.InitialMorale = stream.DeserializeInt("InitialMorale");;
        this.Prestige = stream.DeserializeInt("Prestige");;
        this.DEBUG = stream.DeserializeBool("DEBUG");;
        this.counter = stream.DeserializeInt("counter");;
        this.Counter = stream.DeserializeInt("Counter");;
        this.UpdatePerRound = stream.DeserializeInt("UpdatePerRound");;
        this.ElementsPerSecond = stream.DeserializeInt("ElementsPerSecond");;
        this.WarTimeLimitInSecond = stream.DeserializeInt("WarTimeLimitInSecond");;
        this.starttime = stream.DeserializeFloat("starttime");;
        this.TimeStarted = stream.DeserializeBool("TimeStarted");;
        this.WeaponProficiency = stream.DeserializeInt("WeaponProficiency");;
        this.moraleStandard = stream.DeserializeInt("moraleStandard");;
        		if (stream.DeepSerialize) this.Opponent = stream.DeserializeObject<EntityViewModel>("Opponent");;
        this.BattleState = (BattleState)stream.DeserializeInt("BattleState");;
        this.Career = (Career)stream.DeserializeInt("Career");;
        this.Moving = stream.DeserializeBool("Moving");;
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
        stream.SerializeFloat("Health", this.Health);
        stream.SerializeFloat("Max_Health", this.Max_Health);
        stream.SerializeInt("AttackSpeed", this.AttackSpeed);
        stream.SerializeInt("Movement", (int)this.Movement);;
        stream.SerializeInt("Power", this.Power);
        stream.SerializeBool("isAttack", this.isAttack);
        stream.SerializeInt("Action", (int)this.Action);;
        stream.SerializeInt("MAXROUNDS", this.MAXROUNDS);
        stream.SerializeFloat("Physique", this.Physique);
        stream.SerializeInt("HitPoint", this.HitPoint);
        stream.SerializeInt("WeaponProficieny", this.WeaponProficieny);
        stream.SerializeFloat("Dodge", this.Dodge);
        stream.SerializeFloat("Hurt", this.Hurt);
        stream.SerializeFloat("Dead", this.Dead);
        stream.SerializeInt("InitialMorale", this.InitialMorale);
        stream.SerializeInt("Prestige", this.Prestige);
        stream.SerializeBool("DEBUG", this.DEBUG);
        stream.SerializeInt("counter", this.counter);
        stream.SerializeInt("Counter", this.Counter);
        stream.SerializeInt("UpdatePerRound", this.UpdatePerRound);
        stream.SerializeInt("ElementsPerSecond", this.ElementsPerSecond);
        stream.SerializeInt("WarTimeLimitInSecond", this.WarTimeLimitInSecond);
        stream.SerializeFloat("starttime", this.starttime);
        stream.SerializeBool("TimeStarted", this.TimeStarted);
        stream.SerializeInt("WeaponProficiency", this.WeaponProficiency);
        stream.SerializeInt("moraleStandard", this.moraleStandard);
        if (stream.DeepSerialize) stream.SerializeObject("Opponent", this.Opponent);;
        stream.SerializeInt("BattleState", (int)this.BattleState);;
        stream.SerializeInt("Career", (int)this.Career);;
        stream.SerializeBool("Moving", this.Moving);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_HealthProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_Max_HealthProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_AttackSpeedProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_MovementProperty, false, false, true, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_PowerProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_isAttackProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_ActionProperty, false, false, true, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_MAXROUNDSProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_NameProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_PhysiqueProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_HitPointProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_WeaponProficienyProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_DodgeProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_HurtProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_DeadProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_InitialMoraleProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_PrestigeProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_DEBUGProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_counterProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_CounterProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_UpdatePerRoundProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_ElementsPerSecondProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_WarTimeLimitInSecondProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_starttimeProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_TimeStartedProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_WeaponProficiencyProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_moraleStandardProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_OpponentProperty, true, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_BattleStateProperty, false, false, true, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_PlayListProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_CareerProperty, false, false, true, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_MovingProperty, false, false, false, false));
    }
}

public partial class EntityViewModel {
    
    public EntityViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}

#pragma warning disable CS1591, CS0612, CS3021, IDE1006

namespace OakSave
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Profile : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"enable_aim_assist")]
        public bool EnableAimAssist
        {
            get { return __pbn__EnableAimAssist.GetValueOrDefault(); }
            set { __pbn__EnableAimAssist = value; }
        }
        public bool ShouldSerializeEnableAimAssist() => __pbn__EnableAimAssist != null;
        public void ResetEnableAimAssist() => __pbn__EnableAimAssist = null;
        private bool? __pbn__EnableAimAssist;

        [global::ProtoBuf.ProtoMember(2, Name = @"gamepad_invert_look")]
        public bool GamepadInvertLook
        {
            get { return __pbn__GamepadInvertLook.GetValueOrDefault(); }
            set { __pbn__GamepadInvertLook = value; }
        }
        public bool ShouldSerializeGamepadInvertLook() => __pbn__GamepadInvertLook != null;
        public void ResetGamepadInvertLook() => __pbn__GamepadInvertLook = null;
        private bool? __pbn__GamepadInvertLook;

        [global::ProtoBuf.ProtoMember(3, Name = @"gamepad_invert_turn")]
        public bool GamepadInvertTurn
        {
            get { return __pbn__GamepadInvertTurn.GetValueOrDefault(); }
            set { __pbn__GamepadInvertTurn = value; }
        }
        public bool ShouldSerializeGamepadInvertTurn() => __pbn__GamepadInvertTurn != null;
        public void ResetGamepadInvertTurn() => __pbn__GamepadInvertTurn = null;
        private bool? __pbn__GamepadInvertTurn;

        [global::ProtoBuf.ProtoMember(4, Name = @"gamepad_invert_move")]
        public bool GamepadInvertMove
        {
            get { return __pbn__GamepadInvertMove.GetValueOrDefault(); }
            set { __pbn__GamepadInvertMove = value; }
        }
        public bool ShouldSerializeGamepadInvertMove() => __pbn__GamepadInvertMove != null;
        public void ResetGamepadInvertMove() => __pbn__GamepadInvertMove = null;
        private bool? __pbn__GamepadInvertMove;

        [global::ProtoBuf.ProtoMember(5, Name = @"gamepad_invert_strafe")]
        public bool GamepadInvertStrafe
        {
            get { return __pbn__GamepadInvertStrafe.GetValueOrDefault(); }
            set { __pbn__GamepadInvertStrafe = value; }
        }
        public bool ShouldSerializeGamepadInvertStrafe() => __pbn__GamepadInvertStrafe != null;
        public void ResetGamepadInvertStrafe() => __pbn__GamepadInvertStrafe = null;
        private bool? __pbn__GamepadInvertStrafe;

        [global::ProtoBuf.ProtoMember(6, Name = @"enable_vibration")]
        public bool EnableVibration
        {
            get { return __pbn__EnableVibration.GetValueOrDefault(); }
            set { __pbn__EnableVibration = value; }
        }
        public bool ShouldSerializeEnableVibration() => __pbn__EnableVibration != null;
        public void ResetEnableVibration() => __pbn__EnableVibration = null;
        private bool? __pbn__EnableVibration;

        [global::ProtoBuf.ProtoMember(7, Name = @"invert_mouse_pitch")]
        public bool InvertMousePitch
        {
            get { return __pbn__InvertMousePitch.GetValueOrDefault(); }
            set { __pbn__InvertMousePitch = value; }
        }
        public bool ShouldSerializeInvertMousePitch() => __pbn__InvertMousePitch != null;
        public void ResetInvertMousePitch() => __pbn__InvertMousePitch = null;
        private bool? __pbn__InvertMousePitch;

        [global::ProtoBuf.ProtoMember(8, Name = @"enable_mouse_smoothing")]
        public bool EnableMouseSmoothing
        {
            get { return __pbn__EnableMouseSmoothing.GetValueOrDefault(); }
            set { __pbn__EnableMouseSmoothing = value; }
        }
        public bool ShouldSerializeEnableMouseSmoothing() => __pbn__EnableMouseSmoothing != null;
        public void ResetEnableMouseSmoothing() => __pbn__EnableMouseSmoothing = null;
        private bool? __pbn__EnableMouseSmoothing;


        [global::ProtoBuf.ProtoMember(9, Name = @"mouse_scale")]
        public float MouseScale
        {
            get { return __pbn__MouseScale.GetValueOrDefault(); }
            set { __pbn__MouseScale = value; }
        }
        public bool ShouldSerializeMouseScale() => __pbn__MouseScale != null;
        public void ResetMouseScale() => __pbn__MouseScale = null;
        private float? __pbn__MouseScale;

        [global::ProtoBuf.ProtoMember(10, Name = @"show_damage_numbers")]
        public bool ShowDamageNumbers
        {
            get { return __pbn__ShowDamageNumbers.GetValueOrDefault(); }
            set { __pbn__ShowDamageNumbers = value; }
        }
        public bool ShouldSerializeShowDamageNumbers() => __pbn__ShowDamageNumbers != null;
        public void ResetShowDamageNumbers() => __pbn__ShowDamageNumbers = null;
        private bool? __pbn__ShowDamageNumbers;

        [global::ProtoBuf.ProtoMember(11, Name = @"show_damage_number_icons")]
        public bool ShowDamageNumberIcons
        {
            get { return __pbn__ShowDamageNumberIcons.GetValueOrDefault(); }
            set { __pbn__ShowDamageNumberIcons = value; }
        }
        public bool ShouldSerializeShowDamageNumberIcons() => __pbn__ShowDamageNumberIcons != null;
        public void ResetShowDamageNumberIcons() => __pbn__ShowDamageNumberIcons = null;
        private bool? __pbn__ShowDamageNumberIcons;

        [global::ProtoBuf.ProtoMember(12, Name = @"enable_training_messages")]
        public bool EnableTrainingMessages
        {
            get { return __pbn__EnableTrainingMessages.GetValueOrDefault(); }
            set { __pbn__EnableTrainingMessages = value; }
        }
        public bool ShouldSerializeEnableTrainingMessages() => __pbn__EnableTrainingMessages != null;
        public void ResetEnableTrainingMessages() => __pbn__EnableTrainingMessages = null;
        private bool? __pbn__EnableTrainingMessages;

        [global::ProtoBuf.ProtoMember(13, Name = @"show_text_chat")]
        public bool ShowTextChat
        {
            get { return __pbn__ShowTextChat.GetValueOrDefault(); }
            set { __pbn__ShowTextChat = value; }
        }
        public bool ShouldSerializeShowTextChat() => __pbn__ShowTextChat != null;
        public void ResetShowTextChat() => __pbn__ShowTextChat = null;
        private bool? __pbn__ShowTextChat;

        [global::ProtoBuf.ProtoMember(14, Name = @"center_crosshair")]
        public bool CenterCrosshair
        {
            get { return __pbn__CenterCrosshair.GetValueOrDefault(); }
            set { __pbn__CenterCrosshair = value; }
        }
        public bool ShouldSerializeCenterCrosshair() => __pbn__CenterCrosshair != null;
        public void ResetCenterCrosshair() => __pbn__CenterCrosshair = null;
        private bool? __pbn__CenterCrosshair;

        [global::ProtoBuf.ProtoMember(15, Name = @"toggle_sprint")]
        public bool ToggleSprint
        {
            get { return __pbn__ToggleSprint.GetValueOrDefault(); }
            set { __pbn__ToggleSprint = value; }
        }
        public bool ShouldSerializeToggleSprint() => __pbn__ToggleSprint != null;
        public void ResetToggleSprint() => __pbn__ToggleSprint = null;
        private bool? __pbn__ToggleSprint;

        [global::ProtoBuf.ProtoMember(16, Name = @"toggle_crouch")]
        public bool ToggleCrouch
        {
            get { return __pbn__ToggleCrouch.GetValueOrDefault(); }
            set { __pbn__ToggleCrouch = value; }
        }
        public bool ShouldSerializeToggleCrouch() => __pbn__ToggleCrouch != null;
        public void ResetToggleCrouch() => __pbn__ToggleCrouch = null;
        private bool? __pbn__ToggleCrouch;

        [global::ProtoBuf.ProtoMember(17, Name = @"censor_content")]
        public bool CensorContent
        {
            get { return __pbn__CensorContent.GetValueOrDefault(); }
            set { __pbn__CensorContent = value; }
        }
        public bool ShouldSerializeCensorContent() => __pbn__CensorContent != null;
        public void ResetCensorContent() => __pbn__CensorContent = null;
        private bool? __pbn__CensorContent;

        [global::ProtoBuf.ProtoMember(18, Name = @"music_volume")]
        public float MusicVolume
        {
            get { return __pbn__MusicVolume.GetValueOrDefault(); }
            set { __pbn__MusicVolume = value; }
        }
        public bool ShouldSerializeMusicVolume() => __pbn__MusicVolume != null;
        public void ResetMusicVolume() => __pbn__MusicVolume = null;
        private float? __pbn__MusicVolume;

        [global::ProtoBuf.ProtoMember(19, Name = @"sound_effects_volume")]
        public float SoundEffectsVolume
        {
            get { return __pbn__SoundEffectsVolume.GetValueOrDefault(); }
            set { __pbn__SoundEffectsVolume = value; }
        }
        public bool ShouldSerializeSoundEffectsVolume() => __pbn__SoundEffectsVolume != null;
        public void ResetSoundEffectsVolume() => __pbn__SoundEffectsVolume = null;
        private float? __pbn__SoundEffectsVolume;

        [global::ProtoBuf.ProtoMember(20, Name = @"vo_volume")]
        public float VoVolume
        {
            get { return __pbn__VoVolume.GetValueOrDefault(); }
            set { __pbn__VoVolume = value; }
        }
        public bool ShouldSerializeVoVolume() => __pbn__VoVolume != null;
        public void ResetVoVolume() => __pbn__VoVolume = null;
        private float? __pbn__VoVolume;

        [global::ProtoBuf.ProtoMember(21, Name = @"voice_volume")]
        public float VoiceVolume
        {
            get { return __pbn__VoiceVolume.GetValueOrDefault(); }
            set { __pbn__VoiceVolume = value; }
        }
        public bool ShouldSerializeVoiceVolume() => __pbn__VoiceVolume != null;
        public void ResetVoiceVolume() => __pbn__VoiceVolume = null;
        private float? __pbn__VoiceVolume;

        [global::ProtoBuf.ProtoMember(22, Name = @"enable_optional_vo")]
        public bool EnableOptionalVo
        {
            get { return __pbn__EnableOptionalVo.GetValueOrDefault(); }
            set { __pbn__EnableOptionalVo = value; }
        }
        public bool ShouldSerializeEnableOptionalVo() => __pbn__EnableOptionalVo != null;
        public void ResetEnableOptionalVo() => __pbn__EnableOptionalVo = null;
        private bool? __pbn__EnableOptionalVo;

        [global::ProtoBuf.ProtoMember(23, Name = @"push_to_talk")]
        public bool PushToTalk
        {
            get { return __pbn__PushToTalk.GetValueOrDefault(); }
            set { __pbn__PushToTalk = value; }
        }
        public bool ShouldSerializePushToTalk() => __pbn__PushToTalk != null;
        public void ResetPushToTalk() => __pbn__PushToTalk = null;
        private bool? __pbn__PushToTalk;

        [global::ProtoBuf.ProtoMember(24, Name = @"enable_controller_audio")]
        public bool EnableControllerAudio
        {
            get { return __pbn__EnableControllerAudio.GetValueOrDefault(); }
            set { __pbn__EnableControllerAudio = value; }
        }
        public bool ShouldSerializeEnableControllerAudio() => __pbn__EnableControllerAudio != null;
        public void ResetEnableControllerAudio() => __pbn__EnableControllerAudio = null;
        private bool? __pbn__EnableControllerAudio;

        [global::ProtoBuf.ProtoMember(25, Name = @"speaker_angle_front")]
        public float SpeakerAngleFront
        {
            get { return __pbn__SpeakerAngleFront.GetValueOrDefault(); }
            set { __pbn__SpeakerAngleFront = value; }
        }
        public bool ShouldSerializeSpeakerAngleFront() => __pbn__SpeakerAngleFront != null;
        public void ResetSpeakerAngleFront() => __pbn__SpeakerAngleFront = null;
        private float? __pbn__SpeakerAngleFront;

        [global::ProtoBuf.ProtoMember(26, Name = @"speaker_angle_side")]
        public float SpeakerAngleSide
        {
            get { return __pbn__SpeakerAngleSide.GetValueOrDefault(); }
            set { __pbn__SpeakerAngleSide = value; }
        }
        public bool ShouldSerializeSpeakerAngleSide() => __pbn__SpeakerAngleSide != null;
        public void ResetSpeakerAngleSide() => __pbn__SpeakerAngleSide = null;
        private float? __pbn__SpeakerAngleSide;

        [global::ProtoBuf.ProtoMember(27, Name = @"speaker_angle_back")]
        public float SpeakerAngleBack
        {
            get { return __pbn__SpeakerAngleBack.GetValueOrDefault(); }
            set { __pbn__SpeakerAngleBack = value; }
        }
        public bool ShouldSerializeSpeakerAngleBack() => __pbn__SpeakerAngleBack != null;
        public void ResetSpeakerAngleBack() => __pbn__SpeakerAngleBack = null;
        private float? __pbn__SpeakerAngleBack;

        [global::ProtoBuf.ProtoMember(28, Name = @"speaker_setup")]
        public uint SpeakerSetup
        {
            get { return __pbn__SpeakerSetup.GetValueOrDefault(); }
            set { __pbn__SpeakerSetup = value; }
        }
        public bool ShouldSerializeSpeakerSetup() => __pbn__SpeakerSetup != null;
        public void ResetSpeakerSetup() => __pbn__SpeakerSetup = null;
        private uint? __pbn__SpeakerSetup;

        [global::ProtoBuf.ProtoMember(29, Name = @"mute_audio_on_focus_loss")]
        public bool MuteAudioOnFocusLoss
        {
            get { return __pbn__MuteAudioOnFocusLoss.GetValueOrDefault(); }
            set { __pbn__MuteAudioOnFocusLoss = value; }
        }
        public bool ShouldSerializeMuteAudioOnFocusLoss() => __pbn__MuteAudioOnFocusLoss != null;
        public void ResetMuteAudioOnFocusLoss() => __pbn__MuteAudioOnFocusLoss = null;
        private bool? __pbn__MuteAudioOnFocusLoss;

        [global::ProtoBuf.ProtoMember(34, Name = @"hide_strict_nat_help_dialog")]
        public bool HideStrictNatHelpDialog
        {
            get { return __pbn__HideStrictNatHelpDialog.GetValueOrDefault(); }
            set { __pbn__HideStrictNatHelpDialog = value; }
        }
        public bool ShouldSerializeHideStrictNatHelpDialog() => __pbn__HideStrictNatHelpDialog != null;
        public void ResetHideStrictNatHelpDialog() => __pbn__HideStrictNatHelpDialog = null;
        private bool? __pbn__HideStrictNatHelpDialog;

        [global::ProtoBuf.ProtoMember(35, Name = @"player_input_bindings")]
        public PlayerInputBindings PlayerInputBindings { get; set; }

        [global::ProtoBuf.ProtoMember(36, Name = @"news_hashes")]
        public uint[] NewsHashes { get; set; }

        [global::ProtoBuf.ProtoMember(37, Name = @"last_used_savegame_id")]
        public uint LastUsedSavegameId
        {
            get { return __pbn__LastUsedSavegameId.GetValueOrDefault(); }
            set { __pbn__LastUsedSavegameId = value; }
        }
        public bool ShouldSerializeLastUsedSavegameId() => __pbn__LastUsedSavegameId != null;
        public void ResetLastUsedSavegameId() => __pbn__LastUsedSavegameId = null;
        private uint? __pbn__LastUsedSavegameId;

        [global::ProtoBuf.ProtoMember(38, Name = @"gamepad_hip_sensitivity_level")]
        public int GamepadHipSensitivityLevel
        {
            get { return __pbn__GamepadHipSensitivityLevel.GetValueOrDefault(); }
            set { __pbn__GamepadHipSensitivityLevel = value; }
        }
        public bool ShouldSerializeGamepadHipSensitivityLevel() => __pbn__GamepadHipSensitivityLevel != null;
        public void ResetGamepadHipSensitivityLevel() => __pbn__GamepadHipSensitivityLevel = null;
        private int? __pbn__GamepadHipSensitivityLevel;

        [global::ProtoBuf.ProtoMember(39, Name = @"gamepad_zoomed_sensitivity_level")]
        public int GamepadZoomedSensitivityLevel
        {
            get { return __pbn__GamepadZoomedSensitivityLevel.GetValueOrDefault(); }
            set { __pbn__GamepadZoomedSensitivityLevel = value; }
        }
        public bool ShouldSerializeGamepadZoomedSensitivityLevel() => __pbn__GamepadZoomedSensitivityLevel != null;
        public void ResetGamepadZoomedSensitivityLevel() => __pbn__GamepadZoomedSensitivityLevel = null;
        private int? __pbn__GamepadZoomedSensitivityLevel;

        [global::ProtoBuf.ProtoMember(40, Name = @"gamepad_vehicle_sensitivity_level")]
        public int GamepadVehicleSensitivityLevel
        {
            get { return __pbn__GamepadVehicleSensitivityLevel.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleSensitivityLevel = value; }
        }
        public bool ShouldSerializeGamepadVehicleSensitivityLevel() => __pbn__GamepadVehicleSensitivityLevel != null;
        public void ResetGamepadVehicleSensitivityLevel() => __pbn__GamepadVehicleSensitivityLevel = null;
        private int? __pbn__GamepadVehicleSensitivityLevel;

        [global::ProtoBuf.ProtoMember(41, Name = @"gamepad_movement_dead_zone_x")]
        public float GamepadMovementDeadZoneX
        {
            get { return __pbn__GamepadMovementDeadZoneX.GetValueOrDefault(); }
            set { __pbn__GamepadMovementDeadZoneX = value; }
        }
        public bool ShouldSerializeGamepadMovementDeadZoneX() => __pbn__GamepadMovementDeadZoneX != null;
        public void ResetGamepadMovementDeadZoneX() => __pbn__GamepadMovementDeadZoneX = null;
        private float? __pbn__GamepadMovementDeadZoneX;

        [global::ProtoBuf.ProtoMember(42, Name = @"gamepad_movement_dead_zone_y")]
        public float GamepadMovementDeadZoneY
        {
            get { return __pbn__GamepadMovementDeadZoneY.GetValueOrDefault(); }
            set { __pbn__GamepadMovementDeadZoneY = value; }
        }
        public bool ShouldSerializeGamepadMovementDeadZoneY() => __pbn__GamepadMovementDeadZoneY != null;
        public void ResetGamepadMovementDeadZoneY() => __pbn__GamepadMovementDeadZoneY = null;
        private float? __pbn__GamepadMovementDeadZoneY;

        [global::ProtoBuf.ProtoMember(43, Name = @"gamepad_look_dead_zone_inner_x")]
        public float GamepadLookDeadZoneInnerX
        {
            get { return __pbn__GamepadLookDeadZoneInnerX.GetValueOrDefault(); }
            set { __pbn__GamepadLookDeadZoneInnerX = value; }
        }
        public bool ShouldSerializeGamepadLookDeadZoneInnerX() => __pbn__GamepadLookDeadZoneInnerX != null;
        public void ResetGamepadLookDeadZoneInnerX() => __pbn__GamepadLookDeadZoneInnerX = null;
        private float? __pbn__GamepadLookDeadZoneInnerX;

        [global::ProtoBuf.ProtoMember(44, Name = @"gamepad_look_dead_zone_outer_x")]
        public float GamepadLookDeadZoneOuterX
        {
            get { return __pbn__GamepadLookDeadZoneOuterX.GetValueOrDefault(); }
            set { __pbn__GamepadLookDeadZoneOuterX = value; }
        }
        public bool ShouldSerializeGamepadLookDeadZoneOuterX() => __pbn__GamepadLookDeadZoneOuterX != null;
        public void ResetGamepadLookDeadZoneOuterX() => __pbn__GamepadLookDeadZoneOuterX = null;
        private float? __pbn__GamepadLookDeadZoneOuterX;

        [global::ProtoBuf.ProtoMember(45, Name = @"gamepad_look_dead_zone_inner_y")]
        public float GamepadLookDeadZoneInnerY
        {
            get { return __pbn__GamepadLookDeadZoneInnerY.GetValueOrDefault(); }
            set { __pbn__GamepadLookDeadZoneInnerY = value; }
        }
        public bool ShouldSerializeGamepadLookDeadZoneInnerY() => __pbn__GamepadLookDeadZoneInnerY != null;
        public void ResetGamepadLookDeadZoneInnerY() => __pbn__GamepadLookDeadZoneInnerY = null;
        private float? __pbn__GamepadLookDeadZoneInnerY;

        [global::ProtoBuf.ProtoMember(46, Name = @"gamepad_look_dead_zone_outer_y")]
        public float GamepadLookDeadZoneOuterY
        {
            get { return __pbn__GamepadLookDeadZoneOuterY.GetValueOrDefault(); }
            set { __pbn__GamepadLookDeadZoneOuterY = value; }
        }
        public bool ShouldSerializeGamepadLookDeadZoneOuterY() => __pbn__GamepadLookDeadZoneOuterY != null;
        public void ResetGamepadLookDeadZoneOuterY() => __pbn__GamepadLookDeadZoneOuterY = null;
        private float? __pbn__GamepadLookDeadZoneOuterY;

        [global::ProtoBuf.ProtoMember(47, Name = @"gamepad_vehicle_movement_dead_zone_x")]
        public float GamepadVehicleMovementDeadZoneX
        {
            get { return __pbn__GamepadVehicleMovementDeadZoneX.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleMovementDeadZoneX = value; }
        }
        public bool ShouldSerializeGamepadVehicleMovementDeadZoneX() => __pbn__GamepadVehicleMovementDeadZoneX != null;
        public void ResetGamepadVehicleMovementDeadZoneX() => __pbn__GamepadVehicleMovementDeadZoneX = null;
        private float? __pbn__GamepadVehicleMovementDeadZoneX;

        [global::ProtoBuf.ProtoMember(48, Name = @"gamepad_vehicle_movement_dead_zone_y")]
        public float GamepadVehicleMovementDeadZoneY
        {
            get { return __pbn__GamepadVehicleMovementDeadZoneY.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleMovementDeadZoneY = value; }
        }
        public bool ShouldSerializeGamepadVehicleMovementDeadZoneY() => __pbn__GamepadVehicleMovementDeadZoneY != null;
        public void ResetGamepadVehicleMovementDeadZoneY() => __pbn__GamepadVehicleMovementDeadZoneY = null;
        private float? __pbn__GamepadVehicleMovementDeadZoneY;

        [global::ProtoBuf.ProtoMember(49, Name = @"gamepad_vehicle_look_dead_zone_inner_x")]
        public float GamepadVehicleLookDeadZoneInnerX
        {
            get { return __pbn__GamepadVehicleLookDeadZoneInnerX.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleLookDeadZoneInnerX = value; }
        }
        public bool ShouldSerializeGamepadVehicleLookDeadZoneInnerX() => __pbn__GamepadVehicleLookDeadZoneInnerX != null;
        public void ResetGamepadVehicleLookDeadZoneInnerX() => __pbn__GamepadVehicleLookDeadZoneInnerX = null;
        private float? __pbn__GamepadVehicleLookDeadZoneInnerX;

        [global::ProtoBuf.ProtoMember(50, Name = @"gamepad_vehicle_look_dead_zone_outer_x")]
        public float GamepadVehicleLookDeadZoneOuterX
        {
            get { return __pbn__GamepadVehicleLookDeadZoneOuterX.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleLookDeadZoneOuterX = value; }
        }
        public bool ShouldSerializeGamepadVehicleLookDeadZoneOuterX() => __pbn__GamepadVehicleLookDeadZoneOuterX != null;
        public void ResetGamepadVehicleLookDeadZoneOuterX() => __pbn__GamepadVehicleLookDeadZoneOuterX = null;
        private float? __pbn__GamepadVehicleLookDeadZoneOuterX;

        [global::ProtoBuf.ProtoMember(51, Name = @"gamepad_vehicle_look_dead_zone_inner_y")]
        public float GamepadVehicleLookDeadZoneInnerY
        {
            get { return __pbn__GamepadVehicleLookDeadZoneInnerY.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleLookDeadZoneInnerY = value; }
        }
        public bool ShouldSerializeGamepadVehicleLookDeadZoneInnerY() => __pbn__GamepadVehicleLookDeadZoneInnerY != null;
        public void ResetGamepadVehicleLookDeadZoneInnerY() => __pbn__GamepadVehicleLookDeadZoneInnerY = null;
        private float? __pbn__GamepadVehicleLookDeadZoneInnerY;

        [global::ProtoBuf.ProtoMember(52, Name = @"gamepad_vehicle_look_dead_zone_outer_y")]
        public float GamepadVehicleLookDeadZoneOuterY
        {
            get { return __pbn__GamepadVehicleLookDeadZoneOuterY.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleLookDeadZoneOuterY = value; }
        }
        public bool ShouldSerializeGamepadVehicleLookDeadZoneOuterY() => __pbn__GamepadVehicleLookDeadZoneOuterY != null;
        public void ResetGamepadVehicleLookDeadZoneOuterY() => __pbn__GamepadVehicleLookDeadZoneOuterY = null;
        private float? __pbn__GamepadVehicleLookDeadZoneOuterY;

        [global::ProtoBuf.ProtoMember(53, Name = @"gamepad_left_dead_zone_inner")]
        public float GamepadLeftDeadZoneInner
        {
            get { return __pbn__GamepadLeftDeadZoneInner.GetValueOrDefault(); }
            set { __pbn__GamepadLeftDeadZoneInner = value; }
        }
        public bool ShouldSerializeGamepadLeftDeadZoneInner() => __pbn__GamepadLeftDeadZoneInner != null;
        public void ResetGamepadLeftDeadZoneInner() => __pbn__GamepadLeftDeadZoneInner = null;
        private float? __pbn__GamepadLeftDeadZoneInner;

        [global::ProtoBuf.ProtoMember(54, Name = @"gamepad_left_dead_zone_outer")]
        public float GamepadLeftDeadZoneOuter
        {
            get { return __pbn__GamepadLeftDeadZoneOuter.GetValueOrDefault(); }
            set { __pbn__GamepadLeftDeadZoneOuter = value; }
        }
        public bool ShouldSerializeGamepadLeftDeadZoneOuter() => __pbn__GamepadLeftDeadZoneOuter != null;
        public void ResetGamepadLeftDeadZoneOuter() => __pbn__GamepadLeftDeadZoneOuter = null;
        private float? __pbn__GamepadLeftDeadZoneOuter;

        [global::ProtoBuf.ProtoMember(55, Name = @"gamepad_right_dead_zone_inner")]
        public float GamepadRightDeadZoneInner
        {
            get { return __pbn__GamepadRightDeadZoneInner.GetValueOrDefault(); }
            set { __pbn__GamepadRightDeadZoneInner = value; }
        }
        public bool ShouldSerializeGamepadRightDeadZoneInner() => __pbn__GamepadRightDeadZoneInner != null;
        public void ResetGamepadRightDeadZoneInner() => __pbn__GamepadRightDeadZoneInner = null;
        private float? __pbn__GamepadRightDeadZoneInner;

        [global::ProtoBuf.ProtoMember(56, Name = @"gamepad_right_dead_zone_outer")]
        public float GamepadRightDeadZoneOuter
        {
            get { return __pbn__GamepadRightDeadZoneOuter.GetValueOrDefault(); }
            set { __pbn__GamepadRightDeadZoneOuter = value; }
        }
        public bool ShouldSerializeGamepadRightDeadZoneOuter() => __pbn__GamepadRightDeadZoneOuter != null;
        public void ResetGamepadRightDeadZoneOuter() => __pbn__GamepadRightDeadZoneOuter = null;
        private float? __pbn__GamepadRightDeadZoneOuter;

        [global::ProtoBuf.ProtoMember(57, Name = @"gamepad_look_axial_dead_zone_scale")]
        public float GamepadLookAxialDeadZoneScale
        {
            get { return __pbn__GamepadLookAxialDeadZoneScale.GetValueOrDefault(); }
            set { __pbn__GamepadLookAxialDeadZoneScale = value; }
        }
        public bool ShouldSerializeGamepadLookAxialDeadZoneScale() => __pbn__GamepadLookAxialDeadZoneScale != null;
        public void ResetGamepadLookAxialDeadZoneScale() => __pbn__GamepadLookAxialDeadZoneScale = null;
        private float? __pbn__GamepadLookAxialDeadZoneScale;

        [global::ProtoBuf.ProtoMember(58, Name = @"gamepad_move_axial_dead_zone_scale")]
        public float GamepadMoveAxialDeadZoneScale
        {
            get { return __pbn__GamepadMoveAxialDeadZoneScale.GetValueOrDefault(); }
            set { __pbn__GamepadMoveAxialDeadZoneScale = value; }
        }
        public bool ShouldSerializeGamepadMoveAxialDeadZoneScale() => __pbn__GamepadMoveAxialDeadZoneScale != null;
        public void ResetGamepadMoveAxialDeadZoneScale() => __pbn__GamepadMoveAxialDeadZoneScale = null;
        private float? __pbn__GamepadMoveAxialDeadZoneScale;

        [global::ProtoBuf.ProtoMember(59, Name = @"gamepad_use_advanced_hip_aim_settings")]
        public bool GamepadUseAdvancedHipAimSettings
        {
            get { return __pbn__GamepadUseAdvancedHipAimSettings.GetValueOrDefault(); }
            set { __pbn__GamepadUseAdvancedHipAimSettings = value; }
        }
        public bool ShouldSerializeGamepadUseAdvancedHipAimSettings() => __pbn__GamepadUseAdvancedHipAimSettings != null;
        public void ResetGamepadUseAdvancedHipAimSettings() => __pbn__GamepadUseAdvancedHipAimSettings = null;
        private bool? __pbn__GamepadUseAdvancedHipAimSettings;

        [global::ProtoBuf.ProtoMember(60, Name = @"gamepad_use_advanced_zoomed_aim_settings")]
        public bool GamepadUseAdvancedZoomedAimSettings
        {
            get { return __pbn__GamepadUseAdvancedZoomedAimSettings.GetValueOrDefault(); }
            set { __pbn__GamepadUseAdvancedZoomedAimSettings = value; }
        }
        public bool ShouldSerializeGamepadUseAdvancedZoomedAimSettings() => __pbn__GamepadUseAdvancedZoomedAimSettings != null;
        public void ResetGamepadUseAdvancedZoomedAimSettings() => __pbn__GamepadUseAdvancedZoomedAimSettings = null;
        private bool? __pbn__GamepadUseAdvancedZoomedAimSettings;

        [global::ProtoBuf.ProtoMember(61, Name = @"gamepad_use_advanced_vehicle_aim_settings")]
        public bool GamepadUseAdvancedVehicleAimSettings
        {
            get { return __pbn__GamepadUseAdvancedVehicleAimSettings.GetValueOrDefault(); }
            set { __pbn__GamepadUseAdvancedVehicleAimSettings = value; }
        }
        public bool ShouldSerializeGamepadUseAdvancedVehicleAimSettings() => __pbn__GamepadUseAdvancedVehicleAimSettings != null;
        public void ResetGamepadUseAdvancedVehicleAimSettings() => __pbn__GamepadUseAdvancedVehicleAimSettings = null;
        private bool? __pbn__GamepadUseAdvancedVehicleAimSettings;

        [global::ProtoBuf.ProtoMember(62, Name = @"gamepad_hip_yaw_rate")]
        public float GamepadHipYawRate
        {
            get { return __pbn__GamepadHipYawRate.GetValueOrDefault(); }
            set { __pbn__GamepadHipYawRate = value; }
        }
        public bool ShouldSerializeGamepadHipYawRate() => __pbn__GamepadHipYawRate != null;
        public void ResetGamepadHipYawRate() => __pbn__GamepadHipYawRate = null;
        private float? __pbn__GamepadHipYawRate;

        [global::ProtoBuf.ProtoMember(63, Name = @"gamepad_hip_pitch_rate")]
        public float GamepadHipPitchRate
        {
            get { return __pbn__GamepadHipPitchRate.GetValueOrDefault(); }
            set { __pbn__GamepadHipPitchRate = value; }
        }
        public bool ShouldSerializeGamepadHipPitchRate() => __pbn__GamepadHipPitchRate != null;
        public void ResetGamepadHipPitchRate() => __pbn__GamepadHipPitchRate = null;
        private float? __pbn__GamepadHipPitchRate;

        [global::ProtoBuf.ProtoMember(64, Name = @"gamepad_hip_extra_yaw")]
        public float GamepadHipExtraYaw
        {
            get { return __pbn__GamepadHipExtraYaw.GetValueOrDefault(); }
            set { __pbn__GamepadHipExtraYaw = value; }
        }
        public bool ShouldSerializeGamepadHipExtraYaw() => __pbn__GamepadHipExtraYaw != null;
        public void ResetGamepadHipExtraYaw() => __pbn__GamepadHipExtraYaw = null;
        private float? __pbn__GamepadHipExtraYaw;

        [global::ProtoBuf.ProtoMember(65, Name = @"gamepad_hip_extra_pitch")]
        public float GamepadHipExtraPitch
        {
            get { return __pbn__GamepadHipExtraPitch.GetValueOrDefault(); }
            set { __pbn__GamepadHipExtraPitch = value; }
        }
        public bool ShouldSerializeGamepadHipExtraPitch() => __pbn__GamepadHipExtraPitch != null;
        public void ResetGamepadHipExtraPitch() => __pbn__GamepadHipExtraPitch = null;
        private float? __pbn__GamepadHipExtraPitch;

        [global::ProtoBuf.ProtoMember(66, Name = @"gamepad_hip_ramp_up_time")]
        public float GamepadHipRampUpTime
        {
            get { return __pbn__GamepadHipRampUpTime.GetValueOrDefault(); }
            set { __pbn__GamepadHipRampUpTime = value; }
        }
        public bool ShouldSerializeGamepadHipRampUpTime() => __pbn__GamepadHipRampUpTime != null;
        public void ResetGamepadHipRampUpTime() => __pbn__GamepadHipRampUpTime = null;
        private float? __pbn__GamepadHipRampUpTime;

        [global::ProtoBuf.ProtoMember(67, Name = @"gamepad_hip_ramp_up_delay")]
        public float GamepadHipRampUpDelay
        {
            get { return __pbn__GamepadHipRampUpDelay.GetValueOrDefault(); }
            set { __pbn__GamepadHipRampUpDelay = value; }
        }
        public bool ShouldSerializeGamepadHipRampUpDelay() => __pbn__GamepadHipRampUpDelay != null;
        public void ResetGamepadHipRampUpDelay() => __pbn__GamepadHipRampUpDelay = null;
        private float? __pbn__GamepadHipRampUpDelay;

        [global::ProtoBuf.ProtoMember(68, Name = @"gamepad_zoomed_yaw_rate")]
        public float GamepadZoomedYawRate
        {
            get { return __pbn__GamepadZoomedYawRate.GetValueOrDefault(); }
            set { __pbn__GamepadZoomedYawRate = value; }
        }
        public bool ShouldSerializeGamepadZoomedYawRate() => __pbn__GamepadZoomedYawRate != null;
        public void ResetGamepadZoomedYawRate() => __pbn__GamepadZoomedYawRate = null;
        private float? __pbn__GamepadZoomedYawRate;

        [global::ProtoBuf.ProtoMember(69, Name = @"gamepad_zoomed_pitch_rate")]
        public float GamepadZoomedPitchRate
        {
            get { return __pbn__GamepadZoomedPitchRate.GetValueOrDefault(); }
            set { __pbn__GamepadZoomedPitchRate = value; }
        }
        public bool ShouldSerializeGamepadZoomedPitchRate() => __pbn__GamepadZoomedPitchRate != null;
        public void ResetGamepadZoomedPitchRate() => __pbn__GamepadZoomedPitchRate = null;
        private float? __pbn__GamepadZoomedPitchRate;

        [global::ProtoBuf.ProtoMember(70, Name = @"gamepad_zoomed_extra_yaw")]
        public float GamepadZoomedExtraYaw
        {
            get { return __pbn__GamepadZoomedExtraYaw.GetValueOrDefault(); }
            set { __pbn__GamepadZoomedExtraYaw = value; }
        }
        public bool ShouldSerializeGamepadZoomedExtraYaw() => __pbn__GamepadZoomedExtraYaw != null;
        public void ResetGamepadZoomedExtraYaw() => __pbn__GamepadZoomedExtraYaw = null;
        private float? __pbn__GamepadZoomedExtraYaw;

        [global::ProtoBuf.ProtoMember(71, Name = @"gamepad_zoomed_extra_pitch")]
        public float GamepadZoomedExtraPitch
        {
            get { return __pbn__GamepadZoomedExtraPitch.GetValueOrDefault(); }
            set { __pbn__GamepadZoomedExtraPitch = value; }
        }
        public bool ShouldSerializeGamepadZoomedExtraPitch() => __pbn__GamepadZoomedExtraPitch != null;
        public void ResetGamepadZoomedExtraPitch() => __pbn__GamepadZoomedExtraPitch = null;
        private float? __pbn__GamepadZoomedExtraPitch;

        [global::ProtoBuf.ProtoMember(72, Name = @"gamepad_zoomed_ramp_up_time")]
        public float GamepadZoomedRampUpTime
        {
            get { return __pbn__GamepadZoomedRampUpTime.GetValueOrDefault(); }
            set { __pbn__GamepadZoomedRampUpTime = value; }
        }
        public bool ShouldSerializeGamepadZoomedRampUpTime() => __pbn__GamepadZoomedRampUpTime != null;
        public void ResetGamepadZoomedRampUpTime() => __pbn__GamepadZoomedRampUpTime = null;
        private float? __pbn__GamepadZoomedRampUpTime;

        [global::ProtoBuf.ProtoMember(73, Name = @"gamepad_zoomed_ramp_up_delay")]
        public float GamepadZoomedRampUpDelay
        {
            get { return __pbn__GamepadZoomedRampUpDelay.GetValueOrDefault(); }
            set { __pbn__GamepadZoomedRampUpDelay = value; }
        }
        public bool ShouldSerializeGamepadZoomedRampUpDelay() => __pbn__GamepadZoomedRampUpDelay != null;
        public void ResetGamepadZoomedRampUpDelay() => __pbn__GamepadZoomedRampUpDelay = null;
        private float? __pbn__GamepadZoomedRampUpDelay;

        [global::ProtoBuf.ProtoMember(74, Name = @"gamepad_vehicle_yaw_rate")]
        public float GamepadVehicleYawRate
        {
            get { return __pbn__GamepadVehicleYawRate.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleYawRate = value; }
        }
        public bool ShouldSerializeGamepadVehicleYawRate() => __pbn__GamepadVehicleYawRate != null;
        public void ResetGamepadVehicleYawRate() => __pbn__GamepadVehicleYawRate = null;
        private float? __pbn__GamepadVehicleYawRate;

        [global::ProtoBuf.ProtoMember(75, Name = @"gamepad_vehicle_pitch_rate")]
        public float GamepadVehiclePitchRate
        {
            get { return __pbn__GamepadVehiclePitchRate.GetValueOrDefault(); }
            set { __pbn__GamepadVehiclePitchRate = value; }
        }
        public bool ShouldSerializeGamepadVehiclePitchRate() => __pbn__GamepadVehiclePitchRate != null;
        public void ResetGamepadVehiclePitchRate() => __pbn__GamepadVehiclePitchRate = null;
        private float? __pbn__GamepadVehiclePitchRate;

        [global::ProtoBuf.ProtoMember(76, Name = @"gamepad_vehicle_extra_yaw")]
        public float GamepadVehicleExtraYaw
        {
            get { return __pbn__GamepadVehicleExtraYaw.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleExtraYaw = value; }
        }
        public bool ShouldSerializeGamepadVehicleExtraYaw() => __pbn__GamepadVehicleExtraYaw != null;
        public void ResetGamepadVehicleExtraYaw() => __pbn__GamepadVehicleExtraYaw = null;
        private float? __pbn__GamepadVehicleExtraYaw;

        [global::ProtoBuf.ProtoMember(77, Name = @"gamepad_vehicle_extra_pitch")]
        public float GamepadVehicleExtraPitch
        {
            get { return __pbn__GamepadVehicleExtraPitch.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleExtraPitch = value; }
        }
        public bool ShouldSerializeGamepadVehicleExtraPitch() => __pbn__GamepadVehicleExtraPitch != null;
        public void ResetGamepadVehicleExtraPitch() => __pbn__GamepadVehicleExtraPitch = null;
        private float? __pbn__GamepadVehicleExtraPitch;

        [global::ProtoBuf.ProtoMember(78, Name = @"gamepad_vehicle_ramp_up_time")]
        public float GamepadVehicleRampUpTime
        {
            get { return __pbn__GamepadVehicleRampUpTime.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleRampUpTime = value; }
        }
        public bool ShouldSerializeGamepadVehicleRampUpTime() => __pbn__GamepadVehicleRampUpTime != null;
        public void ResetGamepadVehicleRampUpTime() => __pbn__GamepadVehicleRampUpTime = null;
        private float? __pbn__GamepadVehicleRampUpTime;

        [global::ProtoBuf.ProtoMember(79, Name = @"gamepad_vehicle_ramp_up_delay")]
        public float GamepadVehicleRampUpDelay
        {
            get { return __pbn__GamepadVehicleRampUpDelay.GetValueOrDefault(); }
            set { __pbn__GamepadVehicleRampUpDelay = value; }
        }
        public bool ShouldSerializeGamepadVehicleRampUpDelay() => __pbn__GamepadVehicleRampUpDelay != null;
        public void ResetGamepadVehicleRampUpDelay() => __pbn__GamepadVehicleRampUpDelay = null;
        private float? __pbn__GamepadVehicleRampUpDelay;

        [global::ProtoBuf.ProtoMember(80, Name = @"ironsight_aim_assist")]
        public bool IronsightAimAssist
        {
            get { return __pbn__IronsightAimAssist.GetValueOrDefault(); }
            set { __pbn__IronsightAimAssist = value; }
        }
        public bool ShouldSerializeIronsightAimAssist() => __pbn__IronsightAimAssist != null;
        public void ResetIronsightAimAssist() => __pbn__IronsightAimAssist = null;
        private bool? __pbn__IronsightAimAssist;

        [global::ProtoBuf.ProtoMember(81, Name = @"walking_joystick_scheme")]
        public uint WalkingJoystickScheme
        {
            get { return __pbn__WalkingJoystickScheme.GetValueOrDefault(); }
            set { __pbn__WalkingJoystickScheme = value; }
        }
        public bool ShouldSerializeWalkingJoystickScheme() => __pbn__WalkingJoystickScheme != null;
        public void ResetWalkingJoystickScheme() => __pbn__WalkingJoystickScheme = null;
        private uint? __pbn__WalkingJoystickScheme;

        [global::ProtoBuf.ProtoMember(82, Name = @"driving_joystick_scheme")]
        public uint DrivingJoystickScheme
        {
            get { return __pbn__DrivingJoystickScheme.GetValueOrDefault(); }
            set { __pbn__DrivingJoystickScheme = value; }
        }
        public bool ShouldSerializeDrivingJoystickScheme() => __pbn__DrivingJoystickScheme != null;
        public void ResetDrivingJoystickScheme() => __pbn__DrivingJoystickScheme = null;
        private uint? __pbn__DrivingJoystickScheme;

        [global::ProtoBuf.ProtoMember(83, Name = @"mouse_ads_scale")]
        public float MouseAdsScale
        {
            get { return __pbn__MouseAdsScale.GetValueOrDefault(); }
            set { __pbn__MouseAdsScale = value; }
        }
        public bool ShouldSerializeMouseAdsScale() => __pbn__MouseAdsScale != null;
        public void ResetMouseAdsScale() => __pbn__MouseAdsScale = null;
        private float? __pbn__MouseAdsScale;

        [global::ProtoBuf.ProtoMember(84, Name = @"mouse_vehicle_scale")]
        public float MouseVehicleScale
        {
            get { return __pbn__MouseVehicleScale.GetValueOrDefault(); }
            set { __pbn__MouseVehicleScale = value; }
        }
        public bool ShouldSerializeMouseVehicleScale() => __pbn__MouseVehicleScale != null;
        public void ResetMouseVehicleScale() => __pbn__MouseVehicleScale = null;
        private float? __pbn__MouseVehicleScale;

        [global::ProtoBuf.ProtoMember(85, Name = @"mouse_ironsight_aim_assist")]
        public bool MouseIronsightAimAssist
        {
            get { return __pbn__MouseIronsightAimAssist.GetValueOrDefault(); }
            set { __pbn__MouseIronsightAimAssist = value; }
        }
        public bool ShouldSerializeMouseIronsightAimAssist() => __pbn__MouseIronsightAimAssist != null;
        public void ResetMouseIronsightAimAssist() => __pbn__MouseIronsightAimAssist = null;
        private bool? __pbn__MouseIronsightAimAssist;

        [global::ProtoBuf.ProtoMember(86, Name = @"vehicle_input_mode")]
        public uint VehicleInputMode
        {
            get { return __pbn__VehicleInputMode.GetValueOrDefault(); }
            set { __pbn__VehicleInputMode = value; }
        }
        public bool ShouldSerializeVehicleInputMode() => __pbn__VehicleInputMode != null;
        public void ResetVehicleInputMode() => __pbn__VehicleInputMode = null;
        private uint? __pbn__VehicleInputMode;

        [global::ProtoBuf.ProtoMember(87, Name = @"weapon_aim_toggle")]
        public bool WeaponAimToggle
        {
            get { return __pbn__WeaponAimToggle.GetValueOrDefault(); }
            set { __pbn__WeaponAimToggle = value; }
        }
        public bool ShouldSerializeWeaponAimToggle() => __pbn__WeaponAimToggle != null;
        public void ResetWeaponAimToggle() => __pbn__WeaponAimToggle = null;
        private bool? __pbn__WeaponAimToggle;

        [global::ProtoBuf.ProtoMember(88, Name = @"mantle_requires_button")]
        public bool MantleRequiresButton
        {
            get { return __pbn__MantleRequiresButton.GetValueOrDefault(); }
            set { __pbn__MantleRequiresButton = value; }
        }
        public bool ShouldSerializeMantleRequiresButton() => __pbn__MantleRequiresButton != null;
        public void ResetMantleRequiresButton() => __pbn__MantleRequiresButton = null;
        private bool? __pbn__MantleRequiresButton;

        [global::ProtoBuf.ProtoMember(89, Name = @"fixed_minimap_rotation")]
        public bool FixedMinimapRotation
        {
            get { return __pbn__FixedMinimapRotation.GetValueOrDefault(); }
            set { __pbn__FixedMinimapRotation = value; }
        }
        public bool ShouldSerializeFixedMinimapRotation() => __pbn__FixedMinimapRotation != null;
        public void ResetFixedMinimapRotation() => __pbn__FixedMinimapRotation = null;
        private bool? __pbn__FixedMinimapRotation;

        [global::ProtoBuf.ProtoMember(90, Name = @"map_invert_pitch")]
        public bool MapInvertPitch
        {
            get { return __pbn__MapInvertPitch.GetValueOrDefault(); }
            set { __pbn__MapInvertPitch = value; }
        }
        public bool ShouldSerializeMapInvertPitch() => __pbn__MapInvertPitch != null;
        public void ResetMapInvertPitch() => __pbn__MapInvertPitch = null;
        private bool? __pbn__MapInvertPitch;

        [global::ProtoBuf.ProtoMember(91, Name = @"map_invert_yaw")]
        public bool MapInvertYaw
        {
            get { return __pbn__MapInvertYaw.GetValueOrDefault(); }
            set { __pbn__MapInvertYaw = value; }
        }
        public bool ShouldSerializeMapInvertYaw() => __pbn__MapInvertYaw != null;
        public void ResetMapInvertYaw() => __pbn__MapInvertYaw = null;
        private bool? __pbn__MapInvertYaw;

        [global::ProtoBuf.ProtoMember(92, Name = @"difficulty")]
        public uint Difficulty
        {
            get { return __pbn__Difficulty.GetValueOrDefault(); }
            set { __pbn__Difficulty = value; }
        }
        public bool ShouldSerializeDifficulty() => __pbn__Difficulty != null;
        public void ResetDifficulty() => __pbn__Difficulty = null;
        private uint? __pbn__Difficulty;

        [global::ProtoBuf.ProtoMember(93, Name = @"swap_dual_wield_controls")]
        public bool SwapDualWieldControls
        {
            get { return __pbn__SwapDualWieldControls.GetValueOrDefault(); }
            set { __pbn__SwapDualWieldControls = value; }
        }
        public bool ShouldSerializeSwapDualWieldControls() => __pbn__SwapDualWieldControls != null;
        public void ResetSwapDualWieldControls() => __pbn__SwapDualWieldControls = null;
        private bool? __pbn__SwapDualWieldControls;

        [global::ProtoBuf.ProtoMember(94, Name = @"base_fov")]
        public float BaseFov
        {
            get { return __pbn__BaseFov.GetValueOrDefault(); }
            set { __pbn__BaseFov = value; }
        }
        public bool ShouldSerializeBaseFov() => __pbn__BaseFov != null;
        public void ResetBaseFov() => __pbn__BaseFov = null;
        private float? __pbn__BaseFov;

        [global::ProtoBuf.ProtoMember(95, Name = @"crosshair_neutral_color_frame")]
        public uint CrosshairNeutralColorFrame
        {
            get { return __pbn__CrosshairNeutralColorFrame.GetValueOrDefault(); }
            set { __pbn__CrosshairNeutralColorFrame = value; }
        }
        public bool ShouldSerializeCrosshairNeutralColorFrame() => __pbn__CrosshairNeutralColorFrame != null;
        public void ResetCrosshairNeutralColorFrame() => __pbn__CrosshairNeutralColorFrame = null;
        private uint? __pbn__CrosshairNeutralColorFrame;

        [global::ProtoBuf.ProtoMember(96, Name = @"crosshair_enemy_color_frame")]
        public uint CrosshairEnemyColorFrame
        {
            get { return __pbn__CrosshairEnemyColorFrame.GetValueOrDefault(); }
            set { __pbn__CrosshairEnemyColorFrame = value; }
        }
        public bool ShouldSerializeCrosshairEnemyColorFrame() => __pbn__CrosshairEnemyColorFrame != null;
        public void ResetCrosshairEnemyColorFrame() => __pbn__CrosshairEnemyColorFrame = null;
        private uint? __pbn__CrosshairEnemyColorFrame;

        [global::ProtoBuf.ProtoMember(97, Name = @"crosshair_ally_color_frame")]
        public uint CrosshairAllyColorFrame
        {
            get { return __pbn__CrosshairAllyColorFrame.GetValueOrDefault(); }
            set { __pbn__CrosshairAllyColorFrame = value; }
        }
        public bool ShouldSerializeCrosshairAllyColorFrame() => __pbn__CrosshairAllyColorFrame != null;
        public void ResetCrosshairAllyColorFrame() => __pbn__CrosshairAllyColorFrame = null;
        private uint? __pbn__CrosshairAllyColorFrame;

        [global::ProtoBuf.ProtoMember(98, Name = @"enable_subtitles")]
        public bool EnableSubtitles
        {
            get { return __pbn__EnableSubtitles.GetValueOrDefault(); }
            set { __pbn__EnableSubtitles = value; }
        }
        public bool ShouldSerializeEnableSubtitles() => __pbn__EnableSubtitles != null;
        public void ResetEnableSubtitles() => __pbn__EnableSubtitles = null;
        private bool? __pbn__EnableSubtitles;

        [global::ProtoBuf.ProtoMember(99, Name = @"enable_closed_captions")]
        public bool EnableClosedCaptions
        {
            get { return __pbn__EnableClosedCaptions.GetValueOrDefault(); }
            set { __pbn__EnableClosedCaptions = value; }
        }
        public bool ShouldSerializeEnableClosedCaptions() => __pbn__EnableClosedCaptions != null;
        public void ResetEnableClosedCaptions() => __pbn__EnableClosedCaptions = null;
        private bool? __pbn__EnableClosedCaptions;

        [global::ProtoBuf.ProtoMember(100, Name = @"last_status_menu_page")]
        [global::System.ComponentModel.DefaultValue("")]
        public string LastStatusMenuPage
        {
            get { return __pbn__LastStatusMenuPage ?? ""; }
            set { __pbn__LastStatusMenuPage = value; }
        }
        public bool ShouldSerializeLastStatusMenuPage() => __pbn__LastStatusMenuPage != null;
        public void ResetLastStatusMenuPage() => __pbn__LastStatusMenuPage = null;
        private string __pbn__LastStatusMenuPage;

        [global::ProtoBuf.ProtoMember(101, Name = @"inventory_screen_last_filter")]
        public global::System.Collections.Generic.List<OakProfileLastInventoryFilterInfo> InventoryScreenLastFilters { get; } = new global::System.Collections.Generic.List<OakProfileLastInventoryFilterInfo>();

        [global::ProtoBuf.ProtoMember(102, Name = @"tutorial_info")]
        public OakProfileMenuTutorialInfo TutorialInfo { get; set; }

        [global::ProtoBuf.ProtoMember(103, Name = @"default_network_type")]
        public uint DefaultNetworkType
        {
            get { return __pbn__DefaultNetworkType.GetValueOrDefault(); }
            set { __pbn__DefaultNetworkType = value; }
        }
        public bool ShouldSerializeDefaultNetworkType() => __pbn__DefaultNetworkType != null;
        public void ResetDefaultNetworkType() => __pbn__DefaultNetworkType = null;
        private uint? __pbn__DefaultNetworkType;

        [global::ProtoBuf.ProtoMember(104, Name = @"default_invite_type")]
        public uint DefaultInviteType
        {
            get { return __pbn__DefaultInviteType.GetValueOrDefault(); }
            set { __pbn__DefaultInviteType = value; }
        }
        public bool ShouldSerializeDefaultInviteType() => __pbn__DefaultInviteType != null;
        public void ResetDefaultInviteType() => __pbn__DefaultInviteType = null;
        private uint? __pbn__DefaultInviteType;

        [global::ProtoBuf.ProtoMember(105, Name = @"matchmaking_region")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MatchmakingRegion
        {
            get { return __pbn__MatchmakingRegion ?? ""; }
            set { __pbn__MatchmakingRegion = value; }
        }
        public bool ShouldSerializeMatchmakingRegion() => __pbn__MatchmakingRegion != null;
        public void ResetMatchmakingRegion() => __pbn__MatchmakingRegion = null;
        private string __pbn__MatchmakingRegion;

        [global::ProtoBuf.ProtoMember(106, Name = @"streaming_service")]
        public uint StreamingService
        {
            get { return __pbn__StreamingService.GetValueOrDefault(); }
            set { __pbn__StreamingService = value; }
        }
        public bool ShouldSerializeStreamingService() => __pbn__StreamingService != null;
        public void ResetStreamingService() => __pbn__StreamingService = null;
        private uint? __pbn__StreamingService;

        [global::ProtoBuf.ProtoMember(107, Name = @"max_cached_friend_events")]
        public int MaxCachedFriendEvents
        {
            get { return __pbn__MaxCachedFriendEvents.GetValueOrDefault(); }
            set { __pbn__MaxCachedFriendEvents = value; }
        }
        public bool ShouldSerializeMaxCachedFriendEvents() => __pbn__MaxCachedFriendEvents != null;
        public void ResetMaxCachedFriendEvents() => __pbn__MaxCachedFriendEvents = null;
        private int? __pbn__MaxCachedFriendEvents;

        [global::ProtoBuf.ProtoMember(108, Name = @"max_cached_friend_statuses")]
        public int MaxCachedFriendStatuses
        {
            get { return __pbn__MaxCachedFriendStatuses.GetValueOrDefault(); }
            set { __pbn__MaxCachedFriendStatuses = value; }
        }
        public bool ShouldSerializeMaxCachedFriendStatuses() => __pbn__MaxCachedFriendStatuses != null;
        public void ResetMaxCachedFriendStatuses() => __pbn__MaxCachedFriendStatuses = null;
        private int? __pbn__MaxCachedFriendStatuses;

        [global::ProtoBuf.ProtoMember(109, Name = @"friend_events")]
        public global::System.Collections.Generic.List<string> FriendEvents { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(110, Name = @"friend_statuses")]
        public global::System.Collections.Generic.List<string> FriendStatuses { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(111, Name = @"last_whisper_fetch_events_time")]
        public long LastWhisperFetchEventsTime
        {
            get { return __pbn__LastWhisperFetchEventsTime.GetValueOrDefault(); }
            set { __pbn__LastWhisperFetchEventsTime = value; }
        }
        public bool ShouldSerializeLastWhisperFetchEventsTime() => __pbn__LastWhisperFetchEventsTime != null;
        public void ResetLastWhisperFetchEventsTime() => __pbn__LastWhisperFetchEventsTime = null;
        private long? __pbn__LastWhisperFetchEventsTime;

        [global::ProtoBuf.ProtoMember(112, Name = @"last_whisper_fetch_statuses_time")]
        public long LastWhisperFetchStatusesTime
        {
            get { return __pbn__LastWhisperFetchStatusesTime.GetValueOrDefault(); }
            set { __pbn__LastWhisperFetchStatusesTime = value; }
        }
        public bool ShouldSerializeLastWhisperFetchStatusesTime() => __pbn__LastWhisperFetchStatusesTime != null;
        public void ResetLastWhisperFetchStatusesTime() => __pbn__LastWhisperFetchStatusesTime = null;
        private long? __pbn__LastWhisperFetchStatusesTime;

        [global::ProtoBuf.ProtoMember(132, Name = @"recently_met_players")]
        public global::System.Collections.Generic.List<string> RecentlyMetPlayers { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(133, Name = @"friend_encounters")]
        public global::System.Collections.Generic.List<FriendEncountersEntry> FriendEncounters { get; } = new global::System.Collections.Generic.List<FriendEncountersEntry>();

        [global::ProtoBuf.ProtoMember(134, Name = @"max_friend_encounter_size")]
        public int MaxFriendEncounterSize
        {
            get { return __pbn__MaxFriendEncounterSize.GetValueOrDefault(); }
            set { __pbn__MaxFriendEncounterSize = value; }
        }
        public bool ShouldSerializeMaxFriendEncounterSize() => __pbn__MaxFriendEncounterSize != null;
        public void ResetMaxFriendEncounterSize() => __pbn__MaxFriendEncounterSize = null;
        private int? __pbn__MaxFriendEncounterSize;

        [global::ProtoBuf.ProtoMember(135, Name = @"profile_stats_data")]
        public global::System.Collections.Generic.List<GameStatSaveGameData> ProfileStatsDatas { get; } = new global::System.Collections.Generic.List<GameStatSaveGameData>();

        [global::ProtoBuf.ProtoMember(136, Name = @"bank_inventory_category_list")]
        public global::System.Collections.Generic.List<InventoryCategorySaveData> BankInventoryCategoryLists { get; } = new global::System.Collections.Generic.List<InventoryCategorySaveData>();

        [global::ProtoBuf.ProtoMember(137, Name = @"bank_inventory_list")]
        public global::System.Collections.Generic.List<byte[]> BankInventoryLists { get; } = new global::System.Collections.Generic.List<byte[]>();

        [global::ProtoBuf.ProtoMember(138, Name = @"lost_loot_inventory_list")]
        public global::System.Collections.Generic.List<byte[]> LostLootInventoryLists { get; } = new global::System.Collections.Generic.List<byte[]>();

        [global::ProtoBuf.ProtoMember(139, Name = @"npc_mail_items")]
        public global::System.Collections.Generic.List<OakMailItem> NpcMailItems { get; } = new global::System.Collections.Generic.List<OakMailItem>();

        [global::ProtoBuf.ProtoMember(140, Name = @"mail_guids")]
        public global::System.Collections.Generic.List<string> MailGuids { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(141, Name = @"unread_mail_guids")]
        public global::System.Collections.Generic.List<string> UnreadMailGuids { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(142, Name = @"gear_sold_by_friends")]
        public global::System.Collections.Generic.List<GearSoldByFriendData> GearSoldByFriends { get; } = new global::System.Collections.Generic.List<GearSoldByFriendData>();

        [global::ProtoBuf.ProtoMember(143, Name = @"profile_sdu_list")]
        public global::System.Collections.Generic.List<OakSDUSaveGameData> ProfileSduLists { get; } = new global::System.Collections.Generic.List<OakSDUSaveGameData>();

        [global::ProtoBuf.ProtoMember(144, Name = @"unlocked_customizations")]
        public global::System.Collections.Generic.List<OakCustomizationSaveGameData> UnlockedCustomizations { get; } = new global::System.Collections.Generic.List<OakCustomizationSaveGameData>();

        [global::ProtoBuf.ProtoMember(145, Name = @"unlocked_inventory_customization_parts")]
        public global::System.Collections.Generic.List<OakInventoryCustomizationPartInfo> UnlockedInventoryCustomizationParts { get; } = new global::System.Collections.Generic.List<OakInventoryCustomizationPartInfo>();

        [global::ProtoBuf.ProtoMember(146, Name = @"guardian_rank")]
        public GuardianRankProfileData GuardianRank { get; set; }

        [global::ProtoBuf.ProtoMember(147, Name = @"unlocked_crew_quarters_decorations")]
        public global::System.Collections.Generic.List<CrewQuartersDecorationItemSaveGameData> UnlockedCrewQuartersDecorations { get; } = new global::System.Collections.Generic.List<CrewQuartersDecorationItemSaveGameData>();

        [global::ProtoBuf.ProtoMember(148, Name = @"unlocked_crew_quarters_rooms")]
        public global::System.Collections.Generic.List<CrewQuartersRoomItemSaveGameData> UnlockedCrewQuartersRooms { get; } = new global::System.Collections.Generic.List<CrewQuartersRoomItemSaveGameData>();

        [global::ProtoBuf.ProtoMember(150, Name = @"enable_mouse_acceleration")]
        public bool EnableMouseAcceleration
        {
            get { return __pbn__EnableMouseAcceleration.GetValueOrDefault(); }
            set { __pbn__EnableMouseAcceleration = value; }
        }
        public bool ShouldSerializeEnableMouseAcceleration() => __pbn__EnableMouseAcceleration != null;
        public void ResetEnableMouseAcceleration() => __pbn__EnableMouseAcceleration = null;
        private bool? __pbn__EnableMouseAcceleration;

        [global::ProtoBuf.ProtoMember(151, Name = @"enable_gamepad_input")]
        public bool EnableGamepadInput
        {
            get { return __pbn__EnableGamepadInput.GetValueOrDefault(); }
            set { __pbn__EnableGamepadInput = value; }
        }
        public bool ShouldSerializeEnableGamepadInput() => __pbn__EnableGamepadInput != null;
        public void ResetEnableGamepadInput() => __pbn__EnableGamepadInput = null;
        private bool? __pbn__EnableGamepadInput;

        [global::ProtoBuf.ProtoMember(152, Name = @"use_classic_gamepad_input")]
        public bool UseClassicGamepadInput
        {
            get { return __pbn__UseClassicGamepadInput.GetValueOrDefault(); }
            set { __pbn__UseClassicGamepadInput = value; }
        }
        public bool ShouldSerializeUseClassicGamepadInput() => __pbn__UseClassicGamepadInput != null;
        public void ResetUseClassicGamepadInput() => __pbn__UseClassicGamepadInput = null;
        private bool? __pbn__UseClassicGamepadInput;

        [global::ProtoBuf.ProtoMember(153, Name = @"master_volume")]
        public float MasterVolume
        {
            get { return __pbn__MasterVolume.GetValueOrDefault(); }
            set { __pbn__MasterVolume = value; }
        }
        public bool ShouldSerializeMasterVolume() => __pbn__MasterVolume != null;
        public void ResetMasterVolume() => __pbn__MasterVolume = null;
        private float? __pbn__MasterVolume;

        [global::ProtoBuf.ProtoMember(154, Name = @"monitor_display_type")]
        public uint MonitorDisplayType
        {
            get { return __pbn__MonitorDisplayType.GetValueOrDefault(); }
            set { __pbn__MonitorDisplayType = value; }
        }
        public bool ShouldSerializeMonitorDisplayType() => __pbn__MonitorDisplayType != null;
        public void ResetMonitorDisplayType() => __pbn__MonitorDisplayType = null;
        private uint? __pbn__MonitorDisplayType;

        [global::ProtoBuf.ProtoMember(155, Name = @"graphics_mode")]
        public uint GraphicsMode
        {
            get { return __pbn__GraphicsMode.GetValueOrDefault(); }
            set { __pbn__GraphicsMode = value; }
        }
        public bool ShouldSerializeGraphicsMode() => __pbn__GraphicsMode != null;
        public void ResetGraphicsMode() => __pbn__GraphicsMode = null;
        private uint? __pbn__GraphicsMode;

        [global::ProtoBuf.ProtoMember(156, Name = @"frame_rate_limit")]
        public uint FrameRateLimit
        {
            get { return __pbn__FrameRateLimit.GetValueOrDefault(); }
            set { __pbn__FrameRateLimit = value; }
        }
        public bool ShouldSerializeFrameRateLimit() => __pbn__FrameRateLimit != null;
        public void ResetFrameRateLimit() => __pbn__FrameRateLimit = null;
        private uint? __pbn__FrameRateLimit;

        [global::ProtoBuf.ProtoMember(157, Name = @"base_vehicle_fov")]
        public float BaseVehicleFov
        {
            get { return __pbn__BaseVehicleFov.GetValueOrDefault(); }
            set { __pbn__BaseVehicleFov = value; }
        }
        public bool ShouldSerializeBaseVehicleFov() => __pbn__BaseVehicleFov != null;
        public void ResetBaseVehicleFov() => __pbn__BaseVehicleFov = null;
        private float? __pbn__BaseVehicleFov;

        [global::ProtoBuf.ProtoMember(158, Name = @"graphics_quality")]
        public uint GraphicsQuality
        {
            get { return __pbn__GraphicsQuality.GetValueOrDefault(); }
            set { __pbn__GraphicsQuality = value; }
        }
        public bool ShouldSerializeGraphicsQuality() => __pbn__GraphicsQuality != null;
        public void ResetGraphicsQuality() => __pbn__GraphicsQuality = null;
        private uint? __pbn__GraphicsQuality;

        [global::ProtoBuf.ProtoMember(159, Name = @"anisotropic_filtering")]
        public uint AnisotropicFiltering
        {
            get { return __pbn__AnisotropicFiltering.GetValueOrDefault(); }
            set { __pbn__AnisotropicFiltering = value; }
        }
        public bool ShouldSerializeAnisotropicFiltering() => __pbn__AnisotropicFiltering != null;
        public void ResetAnisotropicFiltering() => __pbn__AnisotropicFiltering = null;
        private uint? __pbn__AnisotropicFiltering;

        [global::ProtoBuf.ProtoMember(160, Name = @"shadow_quality")]
        public uint ShadowQuality
        {
            get { return __pbn__ShadowQuality.GetValueOrDefault(); }
            set { __pbn__ShadowQuality = value; }
        }
        public bool ShouldSerializeShadowQuality() => __pbn__ShadowQuality != null;
        public void ResetShadowQuality() => __pbn__ShadowQuality = null;
        private uint? __pbn__ShadowQuality;

        [global::ProtoBuf.ProtoMember(161, Name = @"display_performance_stats")]
        public uint DisplayPerformanceStats
        {
            get { return __pbn__DisplayPerformanceStats.GetValueOrDefault(); }
            set { __pbn__DisplayPerformanceStats = value; }
        }
        public bool ShouldSerializeDisplayPerformanceStats() => __pbn__DisplayPerformanceStats != null;
        public void ResetDisplayPerformanceStats() => __pbn__DisplayPerformanceStats = null;
        private uint? __pbn__DisplayPerformanceStats;

        [global::ProtoBuf.ProtoMember(162, Name = @"texture_detail")]
        public uint TextureDetail
        {
            get { return __pbn__TextureDetail.GetValueOrDefault(); }
            set { __pbn__TextureDetail = value; }
        }
        public bool ShouldSerializeTextureDetail() => __pbn__TextureDetail != null;
        public void ResetTextureDetail() => __pbn__TextureDetail = null;
        private uint? __pbn__TextureDetail;

        [global::ProtoBuf.ProtoMember(163, Name = @"draw_distance")]
        public uint DrawDistance
        {
            get { return __pbn__DrawDistance.GetValueOrDefault(); }
            set { __pbn__DrawDistance = value; }
        }
        public bool ShouldSerializeDrawDistance() => __pbn__DrawDistance != null;
        public void ResetDrawDistance() => __pbn__DrawDistance = null;
        private uint? __pbn__DrawDistance;

        [global::ProtoBuf.ProtoMember(164, Name = @"clutter")]
        public uint Clutter
        {
            get { return __pbn__Clutter.GetValueOrDefault(); }
            set { __pbn__Clutter = value; }
        }
        public bool ShouldSerializeClutter() => __pbn__Clutter != null;
        public void ResetClutter() => __pbn__Clutter = null;
        private uint? __pbn__Clutter;

        [global::ProtoBuf.ProtoMember(165, Name = @"tessellation")]
        public uint Tessellation
        {
            get { return __pbn__Tessellation.GetValueOrDefault(); }
            set { __pbn__Tessellation = value; }
        }
        public bool ShouldSerializeTessellation() => __pbn__Tessellation != null;
        public void ResetTessellation() => __pbn__Tessellation = null;
        private uint? __pbn__Tessellation;

        [global::ProtoBuf.ProtoMember(166, Name = @"foliage")]
        public uint Foliage
        {
            get { return __pbn__Foliage.GetValueOrDefault(); }
            set { __pbn__Foliage = value; }
        }
        public bool ShouldSerializeFoliage() => __pbn__Foliage != null;
        public void ResetFoliage() => __pbn__Foliage = null;
        private uint? __pbn__Foliage;

        [global::ProtoBuf.ProtoMember(167, Name = @"foliage_shadows")]
        public bool FoliageShadows
        {
            get { return __pbn__FoliageShadows.GetValueOrDefault(); }
            set { __pbn__FoliageShadows = value; }
        }
        public bool ShouldSerializeFoliageShadows() => __pbn__FoliageShadows != null;
        public void ResetFoliageShadows() => __pbn__FoliageShadows = null;
        private bool? __pbn__FoliageShadows;

        [global::ProtoBuf.ProtoMember(168, Name = @"planar_reflections")]
        public bool PlanarReflections
        {
            get { return __pbn__PlanarReflections.GetValueOrDefault(); }
            set { __pbn__PlanarReflections = value; }
        }
        public bool ShouldSerializePlanarReflections() => __pbn__PlanarReflections != null;
        public void ResetPlanarReflections() => __pbn__PlanarReflections = null;
        private bool? __pbn__PlanarReflections;

        [global::ProtoBuf.ProtoMember(169, Name = @"volumetric_fog")]
        public uint VolumetricFog
        {
            get { return __pbn__VolumetricFog.GetValueOrDefault(); }
            set { __pbn__VolumetricFog = value; }
        }
        public bool ShouldSerializeVolumetricFog() => __pbn__VolumetricFog != null;
        public void ResetVolumetricFog() => __pbn__VolumetricFog = null;
        private uint? __pbn__VolumetricFog;

        [global::ProtoBuf.ProtoMember(170, Name = @"screen_space_reflections")]
        public uint ScreenSpaceReflections
        {
            get { return __pbn__ScreenSpaceReflections.GetValueOrDefault(); }
            set { __pbn__ScreenSpaceReflections = value; }
        }
        public bool ShouldSerializeScreenSpaceReflections() => __pbn__ScreenSpaceReflections != null;
        public void ResetScreenSpaceReflections() => __pbn__ScreenSpaceReflections = null;
        private uint? __pbn__ScreenSpaceReflections;

        [global::ProtoBuf.ProtoMember(171, Name = @"character_texture_detail")]
        public uint CharacterTextureDetail
        {
            get { return __pbn__CharacterTextureDetail.GetValueOrDefault(); }
            set { __pbn__CharacterTextureDetail = value; }
        }
        public bool ShouldSerializeCharacterTextureDetail() => __pbn__CharacterTextureDetail != null;
        public void ResetCharacterTextureDetail() => __pbn__CharacterTextureDetail = null;
        private uint? __pbn__CharacterTextureDetail;

        [global::ProtoBuf.ProtoMember(172, Name = @"character_detail")]
        public uint CharacterDetail
        {
            get { return __pbn__CharacterDetail.GetValueOrDefault(); }
            set { __pbn__CharacterDetail = value; }
        }
        public bool ShouldSerializeCharacterDetail() => __pbn__CharacterDetail != null;
        public void ResetCharacterDetail() => __pbn__CharacterDetail = null;
        private uint? __pbn__CharacterDetail;

        [global::ProtoBuf.ProtoMember(173, Name = @"ambient_occlusion_quality")]
        public uint AmbientOcclusionQuality
        {
            get { return __pbn__AmbientOcclusionQuality.GetValueOrDefault(); }
            set { __pbn__AmbientOcclusionQuality = value; }
        }
        public bool ShouldSerializeAmbientOcclusionQuality() => __pbn__AmbientOcclusionQuality != null;
        public void ResetAmbientOcclusionQuality() => __pbn__AmbientOcclusionQuality = null;
        private uint? __pbn__AmbientOcclusionQuality;

        [global::ProtoBuf.ProtoMember(174, Name = @"object_motion_blur")]
        public bool ObjectMotionBlur
        {
            get { return __pbn__ObjectMotionBlur.GetValueOrDefault(); }
            set { __pbn__ObjectMotionBlur = value; }
        }
        public bool ShouldSerializeObjectMotionBlur() => __pbn__ObjectMotionBlur != null;
        public void ResetObjectMotionBlur() => __pbn__ObjectMotionBlur = null;
        private bool? __pbn__ObjectMotionBlur;

        [global::ProtoBuf.ProtoMember(175, Name = @"lens_flare")]
        public bool LensFlare
        {
            get { return __pbn__LensFlare.GetValueOrDefault(); }
            set { __pbn__LensFlare = value; }
        }
        public bool ShouldSerializeLensFlare() => __pbn__LensFlare != null;
        public void ResetLensFlare() => __pbn__LensFlare = null;
        private bool? __pbn__LensFlare;

        [global::ProtoBuf.ProtoMember(176, Name = @"combat_number_long_format")]
        public bool CombatNumberLongFormat
        {
            get { return __pbn__CombatNumberLongFormat.GetValueOrDefault(); }
            set { __pbn__CombatNumberLongFormat = value; }
        }
        public bool ShouldSerializeCombatNumberLongFormat() => __pbn__CombatNumberLongFormat != null;
        public void ResetCombatNumberLongFormat() => __pbn__CombatNumberLongFormat = null;
        private bool? __pbn__CombatNumberLongFormat;

        [global::ProtoBuf.ProtoMember(177, Name = @"show_minimap_legendaries")]
        public bool ShowMinimapLegendaries
        {
            get { return __pbn__ShowMinimapLegendaries.GetValueOrDefault(); }
            set { __pbn__ShowMinimapLegendaries = value; }
        }
        public bool ShouldSerializeShowMinimapLegendaries() => __pbn__ShowMinimapLegendaries != null;
        public void ResetShowMinimapLegendaries() => __pbn__ShowMinimapLegendaries = null;
        private bool? __pbn__ShowMinimapLegendaries;

        [global::ProtoBuf.ProtoMember(178, Name = @"use_player_callouts")]
        public bool UsePlayerCallouts
        {
            get { return __pbn__UsePlayerCallouts.GetValueOrDefault(); }
            set { __pbn__UsePlayerCallouts = value; }
        }
        public bool ShouldSerializeUsePlayerCallouts() => __pbn__UsePlayerCallouts != null;
        public void ResetUsePlayerCallouts() => __pbn__UsePlayerCallouts = null;
        private bool? __pbn__UsePlayerCallouts;

        [global::ProtoBuf.ProtoMember(179, Name = @"friend_event_notification_lifetime")]
        public uint FriendEventNotificationLifetime
        {
            get { return __pbn__FriendEventNotificationLifetime.GetValueOrDefault(); }
            set { __pbn__FriendEventNotificationLifetime = value; }
        }
        public bool ShouldSerializeFriendEventNotificationLifetime() => __pbn__FriendEventNotificationLifetime != null;
        public void ResetFriendEventNotificationLifetime() => __pbn__FriendEventNotificationLifetime = null;
        private uint? __pbn__FriendEventNotificationLifetime;

        [global::ProtoBuf.ProtoMember(180, Name = @"friend_event_notification_frequency")]
        public uint FriendEventNotificationFrequency
        {
            get { return __pbn__FriendEventNotificationFrequency.GetValueOrDefault(); }
            set { __pbn__FriendEventNotificationFrequency = value; }
        }
        public bool ShouldSerializeFriendEventNotificationFrequency() => __pbn__FriendEventNotificationFrequency != null;
        public void ResetFriendEventNotificationFrequency() => __pbn__FriendEventNotificationFrequency = null;
        private uint? __pbn__FriendEventNotificationFrequency;

        [global::ProtoBuf.ProtoMember(181, Name = @"trade_request_reception_type")]
        public uint TradeRequestReceptionType
        {
            get { return __pbn__TradeRequestReceptionType.GetValueOrDefault(); }
            set { __pbn__TradeRequestReceptionType = value; }
        }
        public bool ShouldSerializeTradeRequestReceptionType() => __pbn__TradeRequestReceptionType != null;
        public void ResetTradeRequestReceptionType() => __pbn__TradeRequestReceptionType = null;
        private uint? __pbn__TradeRequestReceptionType;

        [global::ProtoBuf.ProtoMember(182, Name = @"head_bob_scale")]
        public float HeadBobScale
        {
            get { return __pbn__HeadBobScale.GetValueOrDefault(); }
            set { __pbn__HeadBobScale = value; }
        }
        public bool ShouldSerializeHeadBobScale() => __pbn__HeadBobScale != null;
        public void ResetHeadBobScale() => __pbn__HeadBobScale = null;
        private float? __pbn__HeadBobScale;

        [global::ProtoBuf.ProtoMember(184, Name = @"has_seen_first_boot")]
        public bool HasSeenFirstBoot
        {
            get { return __pbn__HasSeenFirstBoot.GetValueOrDefault(); }
            set { __pbn__HasSeenFirstBoot = value; }
        }
        public bool ShouldSerializeHasSeenFirstBoot() => __pbn__HasSeenFirstBoot != null;
        public void ResetHasSeenFirstBoot() => __pbn__HasSeenFirstBoot = null;
        private bool? __pbn__HasSeenFirstBoot;

        [global::ProtoBuf.ProtoMember(189, Name = @"subs_cc_size")]
        public float SubsCcSize
        {
            get { return __pbn__SubsCcSize.GetValueOrDefault(); }
            set { __pbn__SubsCcSize = value; }
        }
        public bool ShouldSerializeSubsCcSize() => __pbn__SubsCcSize != null;
        public void ResetSubsCcSize() => __pbn__SubsCcSize = null;
        private float? __pbn__SubsCcSize;

        [global::ProtoBuf.ProtoMember(190, Name = @"cc_subs_background_opacity")]
        public float CcSubsBackgroundOpacity
        {
            get { return __pbn__CcSubsBackgroundOpacity.GetValueOrDefault(); }
            set { __pbn__CcSubsBackgroundOpacity = value; }
        }
        public bool ShouldSerializeCcSubsBackgroundOpacity() => __pbn__CcSubsBackgroundOpacity != null;
        public void ResetCcSubsBackgroundOpacity() => __pbn__CcSubsBackgroundOpacity = null;
        private float? __pbn__CcSubsBackgroundOpacity;

        [global::ProtoBuf.ProtoMember(191, Name = @"walking_button_scheme")]
        public uint WalkingButtonScheme
        {
            get { return __pbn__WalkingButtonScheme.GetValueOrDefault(); }
            set { __pbn__WalkingButtonScheme = value; }
        }
        public bool ShouldSerializeWalkingButtonScheme() => __pbn__WalkingButtonScheme != null;
        public void ResetWalkingButtonScheme() => __pbn__WalkingButtonScheme = null;
        private uint? __pbn__WalkingButtonScheme;

        [global::ProtoBuf.ProtoMember(192, Name = @"driving_button_scheme")]
        public uint DrivingButtonScheme
        {
            get { return __pbn__DrivingButtonScheme.GetValueOrDefault(); }
            set { __pbn__DrivingButtonScheme = value; }
        }
        public bool ShouldSerializeDrivingButtonScheme() => __pbn__DrivingButtonScheme != null;
        public void ResetDrivingButtonScheme() => __pbn__DrivingButtonScheme = null;
        private uint? __pbn__DrivingButtonScheme;

        [global::ProtoBuf.ProtoMember(193, Name = @"glyph_mode")]
        public uint GlyphMode
        {
            get { return __pbn__GlyphMode.GetValueOrDefault(); }
            set { __pbn__GlyphMode = value; }
        }
        public bool ShouldSerializeGlyphMode() => __pbn__GlyphMode != null;
        public void ResetGlyphMode() => __pbn__GlyphMode = null;
        private uint? __pbn__GlyphMode;

        [global::ProtoBuf.ProtoMember(194, Name = @"use_MPH")]
        public bool useMPH
        {
            get { return __pbn__useMPH.GetValueOrDefault(); }
            set { __pbn__useMPH = value; }
        }
        public bool ShouldSerializeuseMPH() => __pbn__useMPH != null;
        public void ResetuseMPH() => __pbn__useMPH = null;
        private bool? __pbn__useMPH;

        [global::ProtoBuf.ProtoMember(195, Name = @"registered_downloadable_entitlements")]
        public global::System.Collections.Generic.List<RegisteredDownloadableEntitlements> RegisteredDownloadableEntitlements { get; } = new global::System.Collections.Generic.List<RegisteredDownloadableEntitlements>();

        [global::ProtoBuf.ProtoMember(196, Name = @"seen_news_items")]
        public global::System.Collections.Generic.List<string> SeenNewsItems { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(197, Name = @"auto_centering_enabled")]
        public bool AutoCenteringEnabled
        {
            get { return __pbn__AutoCenteringEnabled.GetValueOrDefault(); }
            set { __pbn__AutoCenteringEnabled = value; }
        }
        public bool ShouldSerializeAutoCenteringEnabled() => __pbn__AutoCenteringEnabled != null;
        public void ResetAutoCenteringEnabled() => __pbn__AutoCenteringEnabled = null;
        private bool? __pbn__AutoCenteringEnabled;

        [global::ProtoBuf.ProtoMember(198, Name = @"increased_chance_for_subscribers")]
        public bool IncreasedChanceForSubscribers
        {
            get { return __pbn__IncreasedChanceForSubscribers.GetValueOrDefault(); }
            set { __pbn__IncreasedChanceForSubscribers = value; }
        }
        public bool ShouldSerializeIncreasedChanceForSubscribers() => __pbn__IncreasedChanceForSubscribers != null;
        public void ResetIncreasedChanceForSubscribers() => __pbn__IncreasedChanceForSubscribers = null;
        private bool? __pbn__IncreasedChanceForSubscribers;

        [global::ProtoBuf.ProtoMember(199, Name = @"rare_chest_event_enabled")]
        public bool RareChestEventEnabled
        {
            get { return __pbn__RareChestEventEnabled.GetValueOrDefault(); }
            set { __pbn__RareChestEventEnabled = value; }
        }
        public bool ShouldSerializeRareChestEventEnabled() => __pbn__RareChestEventEnabled != null;
        public void ResetRareChestEventEnabled() => __pbn__RareChestEventEnabled = null;
        private bool? __pbn__RareChestEventEnabled;

        [global::ProtoBuf.ProtoMember(200, Name = @"badass_event_enabled")]
        public bool BadassEventEnabled
        {
            get { return __pbn__BadassEventEnabled.GetValueOrDefault(); }
            set { __pbn__BadassEventEnabled = value; }
        }
        public bool ShouldSerializeBadassEventEnabled() => __pbn__BadassEventEnabled != null;
        public void ResetBadassEventEnabled() => __pbn__BadassEventEnabled = null;
        private bool? __pbn__BadassEventEnabled;

        [global::ProtoBuf.ProtoMember(201, Name = @"pinata_event_enabled")]
        public bool PinataEventEnabled
        {
            get { return __pbn__PinataEventEnabled.GetValueOrDefault(); }
            set { __pbn__PinataEventEnabled = value; }
        }
        public bool ShouldSerializePinataEventEnabled() => __pbn__PinataEventEnabled != null;
        public void ResetPinataEventEnabled() => __pbn__PinataEventEnabled = null;
        private bool? __pbn__PinataEventEnabled;

        [global::ProtoBuf.ProtoMember(202, Name = @"min_time_between_badass_events")]
        public int MinTimeBetweenBadassEvents
        {
            get { return __pbn__MinTimeBetweenBadassEvents.GetValueOrDefault(); }
            set { __pbn__MinTimeBetweenBadassEvents = value; }
        }
        public bool ShouldSerializeMinTimeBetweenBadassEvents() => __pbn__MinTimeBetweenBadassEvents != null;
        public void ResetMinTimeBetweenBadassEvents() => __pbn__MinTimeBetweenBadassEvents = null;
        private int? __pbn__MinTimeBetweenBadassEvents;

        [global::ProtoBuf.ProtoMember(203, Name = @"hud_scale_multiplier")]
        public float HudScaleMultiplier
        {
            get { return __pbn__HudScaleMultiplier.GetValueOrDefault(); }
            set { __pbn__HudScaleMultiplier = value; }
        }
        public bool ShouldSerializeHudScaleMultiplier() => __pbn__HudScaleMultiplier != null;
        public void ResetHudScaleMultiplier() => __pbn__HudScaleMultiplier = null;
        private float? __pbn__HudScaleMultiplier;

        [global::ProtoBuf.ProtoMember(204, Name = @"disable_spatial_audio")]
        public bool DisableSpatialAudio
        {
            get { return __pbn__DisableSpatialAudio.GetValueOrDefault(); }
            set { __pbn__DisableSpatialAudio = value; }
        }
        public bool ShouldSerializeDisableSpatialAudio() => __pbn__DisableSpatialAudio != null;
        public void ResetDisableSpatialAudio() => __pbn__DisableSpatialAudio = null;
        private bool? __pbn__DisableSpatialAudio;

        [global::ProtoBuf.ProtoContract()]
        public partial class FriendEncountersEntry : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"key")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Key
            {
                get { return __pbn__Key ?? ""; }
                set { __pbn__Key = value; }
            }
            public bool ShouldSerializeKey() => __pbn__Key != null;
            public void ResetKey() => __pbn__Key = null;
            private string __pbn__Key;

            [global::ProtoBuf.ProtoMember(2, Name = @"value")]
            public OakFriendEncounterData Value { get; set; }

        }

    }

}


#pragma warning restore CS1591, CS0612, CS3021, IDE1006

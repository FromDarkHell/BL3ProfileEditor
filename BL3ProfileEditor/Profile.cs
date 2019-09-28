using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace BL3ProfileEditor
{
    [ProtoContract]
    public class Profile : INotifyPropertyChanged
    {
        #region Fields
        private bool _muteAudioOnFocusLoss;
        private uint _difficulty;
        private bool _combatNumberLongFormat;

        private List<OakMailItem> _npcMailItems = new List<OakMailItem>();
        private List<string> _mailGuids = new List<string>();
        private List<string> _unreadMailGuids = new List<string>();

        private List<OakCustomizationSaveGameData> _unlockedCustomizations = new List<OakCustomizationSaveGameData>();
        private List<OakInventoryCustomizationPartInfo> _unlockedInventoryCustomizationParts = new List<OakInventoryCustomizationPartInfo>();

        private GuardianRankProfileData _guardianRank;

        private List<CrewQuartersDecorationItemSaveGameData> _crewQuartersDecorations = new List<CrewQuartersDecorationItemSaveGameData>();
        private List<CrewQuartersRoomItemSaveGameData> _crewQuartersRooms = new List<CrewQuartersRoomItemSaveGameData>();


        #endregion

        #region Properties

        #region Assorted Things
        [ProtoMember(29, IsRequired = true)]
        public bool muteAudioOnFocusLoss
        {
            get { return _muteAudioOnFocusLoss; }
            set
            {
                if (value != _muteAudioOnFocusLoss)
                {
                    _muteAudioOnFocusLoss = value;
                    NotifyOfPropertyChange(nameof(muteAudioOnFocusLoss));
                }
            }
        }


        [ProtoMember(92, IsRequired = true)]
        public uint difficulty
        {
            get { return _difficulty; }
            set
            {
                if (value != _difficulty)
                {
                    _difficulty = value;
                    NotifyOfPropertyChange(nameof(difficulty));
                }
            }
        }

        [ProtoMember(176, IsRequired = true)]
        public bool combatNumberLongFormat
        {
            get { return _combatNumberLongFormat; }
            set
            {
                if (value != _combatNumberLongFormat)
                {
                    _combatNumberLongFormat = value;
                    NotifyOfPropertyChange(nameof(combatNumberLongFormat));
                }
            }
        }
        #endregion

        #region Mail
        [ProtoMember(139, IsRequired = true)]
        public List<OakMailItem> npcMailItems
        {
            get { return _npcMailItems; }
            set
            {
                if (value != _npcMailItems)
                {
                    _npcMailItems = value;
                    NotifyOfPropertyChange(nameof(npcMailItems));
                }
            }
        }

        [ProtoMember(140, IsRequired = true)]
        public List<string> mailGuids
        {
            get { return _mailGuids; }
            set
            {
                if (value != _mailGuids)
                {
                    _mailGuids = value;
                    NotifyOfPropertyChange(nameof(mailGuids));
                }
            }
        }

        [ProtoMember(141, IsRequired = true)]
        public List<string> unreadMailGuids
        {
            get { return _unreadMailGuids; }
            set
            {
                if (value != _unreadMailGuids)
                {
                    _unreadMailGuids = value;
                    NotifyOfPropertyChange(nameof(unreadMailGuids));
                }
            }
        }

        #endregion

        #region Customizations

        #region Skins

        [ProtoMember(144, IsRequired = true)]
        public List<OakCustomizationSaveGameData> unlockedCustomizations
        {
            get { return _unlockedCustomizations; }
            set
            {
                if (value != _unlockedCustomizations)
                {
                    _unlockedCustomizations = value;
                    NotifyOfPropertyChange(nameof(unlockedCustomizations));
                }
            }
        }
        [ProtoMember(145, IsRequired = true)]
        public List<OakInventoryCustomizationPartInfo> unlockedInventoryCustomizationParts
        {
            get { return _unlockedInventoryCustomizationParts; }
            set
            {
                if (value != _unlockedInventoryCustomizationParts)
                {
                    _unlockedInventoryCustomizationParts = value;
                    NotifyOfPropertyChange(nameof(unlockedInventoryCustomizationParts));
                }
            }
        }

        #endregion

        #region Crew Quarters
        [ProtoMember(147, IsRequired = true)]
        public List<CrewQuartersDecorationItemSaveGameData> crewQuartersDecorations
        {
            get { return _crewQuartersDecorations; }
            set
            {
                if (value != _crewQuartersDecorations)
                {
                    _crewQuartersDecorations = value;
                    NotifyOfPropertyChange(nameof(crewQuartersDecorations));
                }
            }
        }
        [ProtoMember(148, IsRequired = true)]
        public List<CrewQuartersRoomItemSaveGameData> crewQuartersRooms
        {
            get { return _crewQuartersRooms; }
            set
            {
                if (value != _crewQuartersRooms)
                {
                    _crewQuartersRooms = value;
                    NotifyOfPropertyChange(nameof(crewQuartersRooms));
                }
            }
        }

        #endregion

        #endregion

        #region Guardian Rank
        [ProtoMember(146, IsRequired = true)]
        public GuardianRankProfileData guardianRank
        {
            get { return _guardianRank; }
            set
            {
                if (value != _guardianRank)
                {
                    _guardianRank = value;
                    NotifyOfPropertyChange(nameof(guardianRank));
                }
            }
        }
        #endregion

        #endregion

        #region Serialiation
        [ProtoAfterDeserialization]
        private void OnDeserialization()
        {
            this._npcMailItems = this._npcMailItems ?? new List<OakMailItem>();
            this._mailGuids = this._mailGuids ?? new List<string>();
            this._unreadMailGuids = this._unreadMailGuids ?? new List<string>();
            this._unlockedCustomizations = this._unlockedCustomizations ?? new List<OakCustomizationSaveGameData>();
            this._unlockedInventoryCustomizationParts = this._unlockedInventoryCustomizationParts ?? new List<OakInventoryCustomizationPartInfo>();
            this._crewQuartersDecorations = this._crewQuartersDecorations ?? new List<CrewQuartersDecorationItemSaveGameData>();
            this._crewQuartersRooms = this._crewQuartersRooms ?? new List<CrewQuartersRoomItemSaveGameData>();
        }

        private bool ShouldSerializenpcMailItems()
        {
            return this._npcMailItems != null && this._npcMailItems.Count > 0;
        }

        private bool ShouldSerializemailGuids()
        {
            return this._mailGuids != null && this._mailGuids.Count > 0;
        }

        private bool ShouldSerializeunreadMailGuids()
        {
            return this._unreadMailGuids != null && this._unreadMailGuids.Count > 0;
        }

        private bool ShouldSerializeunlockedCustomizations()
        {
            return this._unlockedCustomizations != null && this._unlockedCustomizations.Count > 0;
        }

        private bool ShouldSerializeunlockedInventoryCustomizationParts()
        {
            return this._unlockedInventoryCustomizationParts != null && this.unlockedInventoryCustomizationParts.Count > 0;
        }

        private bool ShouldSerializecrewQuartersDecorations()
        {
            return this._crewQuartersDecorations != null && this.crewQuartersDecorations.Count > 0;
        }

        private bool ShouldSerializecrewQuartersRooms()
        {
            return this._crewQuartersRooms != null && this.crewQuartersRooms.Count > 0;
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [ProtoContract]
    public class OakMailItem : INotifyPropertyChanged
    {
        #region Fields
        private uint _mailItemType;
        private string _senderDisplayName;
        private string _subject;
        private string _body;
        private string _gearSerialNumber;
        private string _mailGUID;
        private long _dateSent;
        private long _expirationDate;
        private string _fromPlayerID;
        private bool _hasBeenRead;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = true)]
        public uint mailItemType
        {
            get { return _mailItemType; }
            set
            {
                if (value != _mailItemType)
                {
                    _mailItemType = value;
                    NotifyOfPropertyChange(nameof(mailItemType));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public string senderDisplayName
        {
            get { return _senderDisplayName; }
            set
            {
                if (value != _senderDisplayName)
                {
                    _senderDisplayName = value;
                    NotifyOfPropertyChange(nameof(senderDisplayName));
                }
            }
        }

        [ProtoMember(3, IsRequired = true)]
        public string subject
        {
            get { return _subject; }
            set
            {
                if (value != _subject)
                {
                    _subject = value;
                    NotifyOfPropertyChange(nameof(subject));
                }
            }
        }

        [ProtoMember(4, IsRequired = true)]
        public string body
        {
            get { return _body; }
            set
            {
                if (value != _body)
                {
                    _body = value;
                    NotifyOfPropertyChange(nameof(body));
                }
            }
        }

        [ProtoMember(5, IsRequired = true)]
        public string gearSerialNumber
        {
            get { return _gearSerialNumber; }
            set
            {
                if (value != _gearSerialNumber)
                {
                    _gearSerialNumber = value;
                    NotifyOfPropertyChange(nameof(gearSerialNumber));
                }
            }
        }

        [ProtoMember(6, IsRequired = true)]
        public string mailGUID
        {
            get { return _mailGUID; }
            set
            {
                if (value != _mailGUID)
                {
                    _mailGUID = value;
                    NotifyOfPropertyChange(nameof(mailGUID));
                }
            }
        }

        [ProtoMember(7, IsRequired = true)]
        public long dateSent
        {
            get { return _dateSent; }
            set
            {
                if (value != _dateSent)
                {
                    _dateSent = value;
                    NotifyOfPropertyChange(nameof(dateSent));
                }
            }
        }

        [ProtoMember(8, IsRequired = true)]
        public long expirationDate
        {
            get { return _expirationDate; }
            set
            {
                if (value != _expirationDate)
                {
                    _expirationDate = value;
                    NotifyOfPropertyChange(nameof(expirationDate));
                }
            }
        }

        [ProtoMember(9, IsRequired = true)]
        public string fromPlayerID
        {
            get { return _fromPlayerID; }
            set
            {
                if (value != _fromPlayerID)
                {
                    _fromPlayerID = value;
                    NotifyOfPropertyChange(nameof(fromPlayerID));
                }
            }
        }

        [ProtoMember(10, IsRequired = true)]
        public bool hasBeenRead
        {
            get { return _hasBeenRead; }
            set
            {
                if (value != _hasBeenRead)
                {
                    _hasBeenRead = value;
                    NotifyOfPropertyChange(nameof(hasBeenRead));
                }
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #region Customizations

    [ProtoContract]
    public class OakCustomizationSaveGameData : INotifyPropertyChanged
    {
        #region Fields
        private bool _isNew;
        private string _customizationAssetPath;

        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = true)]
        public bool isNew
        {
            get { return _isNew; }
            set
            {
                if (value != _isNew)
                {
                    _isNew = value;
                    NotifyOfPropertyChange(nameof(isNew));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public string customizationAssetPath
        {
            get { return _customizationAssetPath; }
            set
            {
                if (value != _customizationAssetPath)
                {
                    _customizationAssetPath = value;
                    NotifyOfPropertyChange(nameof(customizationAssetPath));
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [ProtoContract]
    public class OakInventoryCustomizationPartInfo : INotifyPropertyChanged
    {
        #region Fields
        private uint _customizationPartHash;
        private bool _isNew;
        #endregion

        #region Properties
        [ProtoMember(2, IsRequired = true)]
        public bool isNew
        {
            get { return _isNew; }
            set
            {
                if (value != _isNew)
                {
                    _isNew = value;
                    NotifyOfPropertyChange(nameof(isNew));
                }
            }
        }

        [ProtoMember(1, IsRequired = true)]
        public uint customizationPartHash
        {
            get { return _customizationPartHash; }
            set
            {
                if (value != _customizationPartHash)
                {
                    _customizationPartHash = value;
                    NotifyOfPropertyChange(nameof(customizationPartHash));
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #region Crew Quarters
    [ProtoContract]
    public class CrewQuartersDecorationItemSaveGameData : INotifyPropertyChanged
    {

        #region Fields
        private bool _isNew;
        private string _decorationItemAssetPath;

        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = true)]
        public bool isNew
        {
            get { return _isNew; }
            set
            {
                if (value != _isNew)
                {
                    _isNew = value;
                    NotifyOfPropertyChange(nameof(isNew));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public string decorationItemAssetPath
        {
            get { return _decorationItemAssetPath; }
            set
            {
                if (value != _decorationItemAssetPath)
                {
                    _decorationItemAssetPath = value;
                    NotifyOfPropertyChange(nameof(decorationItemAssetPath));
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [ProtoContract]
    public class CrewQuartersRoomItemSaveGameData : INotifyPropertyChanged
    {
        #region Fields
        private bool _isNew;
        private string _roomItemAssetPath;

        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = true)]
        public bool isNew
        {
            get { return _isNew; }
            set
            {
                if (value != _isNew)
                {
                    _isNew = value;
                    NotifyOfPropertyChange(nameof(isNew));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public string roomItemAssetPath
        {
            get { return _roomItemAssetPath; }
            set
            {
                if (value != _roomItemAssetPath)
                {
                    _roomItemAssetPath = value;
                    NotifyOfPropertyChange(nameof(roomItemAssetPath));
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion

    #endregion

    #region Guardian Rank
    [ProtoContract]
    public class GuardianRankProfileData : INotifyPropertyChanged
    {
        #region Fields
        private int _availableTokens;
        private List<GuardianRankRewardSaveGameData> _rankRewards = new List<GuardianRankRewardSaveGameData>();
        private int _guardianRank;
        private int _guardianExperience;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = true)]
        public int availableTokens
        {
            get { return _availableTokens; }
            set
            {
                if (value != _availableTokens)
                {
                    _availableTokens = value;
                    NotifyOfPropertyChange(nameof(availableTokens));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public List<GuardianRankRewardSaveGameData> rankRewards
        {
            get { return _rankRewards; }
            set
            {
                if (value != _rankRewards)
                {
                    _rankRewards = value;
                    NotifyOfPropertyChange(nameof(rankRewards));
                }
            }
        }

        [ProtoMember(3, IsRequired = true)]
        public int guardianRank
        {
            get { return _guardianRank; }
            set
            {
                if (value != _guardianRank)
                {
                    _guardianRank = value;
                    NotifyOfPropertyChange(nameof(guardianRank));
                }
            }
        }

        [ProtoMember(4, IsRequired = true)]
        public int guardianExperience
        {
            get { return _guardianExperience; }
            set
            {
                if (value != _guardianExperience)
                {
                    _guardianExperience = value;
                    NotifyOfPropertyChange(nameof(guardianExperience));
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [ProtoContract]
    public class GuardianRankRewardSaveGameData : INotifyPropertyChanged
    {
        #region Fields
        private int _numTokens;
        private string _rewardDataPath;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = true)]
        public int numTokens
        {
            get { return _numTokens; }
            set
            {
                if (value != _numTokens)
                {
                    _numTokens = value;
                    NotifyOfPropertyChange(nameof(numTokens));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public string rewardDataPath
        {
            get { return _rewardDataPath; }
            set
            {
                if (value != _rewardDataPath)
                {
                    _rewardDataPath = value;
                    NotifyOfPropertyChange(nameof(rewardDataPath));
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion
}
﻿using System.Collections.Generic;
using Diz.Core.model;
using Diz.Core.util;
using DiztinGUIsh;

namespace Diz.Core.serialization
{
    public class ImportRomSettings : PropertyNotifyChanged
    {
        private RomMapMode mode;
        private byte[] romBytes;
        private string romFilename;

        public RomMapMode RomMapMode
        {
            get => mode;
            set => SetField(ref mode, value);
        }
        
        public int RomSettingsOffset => RomUtil.GetRomSettingOffset(RomMapMode);

        public RomSpeed RomSpeed => RomBytes != null ? RomUtil.GetRomSpeed(RomSettingsOffset, RomBytes) : default;

        // todo: add INotify stuff if we care. probably dont need to.
        public Dictionary<int, Label> InitialLabels { get; set; }
        public Dictionary<int, FlagType> InitialHeaderFlags { get; set; }

        public byte[] RomBytes
        {
            get => romBytes;
            set => SetField(ref romBytes, value);
        }

        public string RomFilename
        {
            get => romFilename;
            set => SetField(ref romFilename, value);
        }
    }
}
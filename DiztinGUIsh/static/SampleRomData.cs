﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiztinGUIsh.Properties;

namespace DiztinGUIsh
{
    class SampleRomData : Data
    {
        // TODO: this was originally how this thing was setup, we probably should inject this in somewhere.
        // I don't remember how it interacts with our sample RomBytes data
        //while (sampleTable.Count < 0x8000)
        //    sampleTable.Add(new ROMByte());

        public static SampleRomData SampleData = new SampleRomData
        {
            // random sample code I made up; hopefully it shows a little bit of
            // everything so you can see how the settings will effect the output
            RomBytes = new RomBytes {
                new ROMByte {Rom = 0x78, TypeFlag = Data.FlagType.Opcode, MFlag = true, XFlag = true, Point = Data.InOutPoint.InPoint},
                new ROMByte {Rom = 0xA9, TypeFlag = Data.FlagType.Opcode, MFlag = true, XFlag = true},
                new ROMByte {Rom = 0x01, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0x8D, TypeFlag = Data.FlagType.Opcode, MFlag = true, XFlag = true},
                new ROMByte {Rom = 0x0D, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0x42, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0x5C, TypeFlag = Data.FlagType.Opcode, MFlag = true, XFlag = true, Point = Data.InOutPoint.EndPoint},
                new ROMByte {Rom = 0x0A, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0xC2, TypeFlag = Data.FlagType.Opcode, MFlag = true, XFlag = true, Point = Data.InOutPoint.InPoint},
                new ROMByte {Rom = 0x30, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0xA9, TypeFlag = Data.FlagType.Opcode},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0x21, TypeFlag = Data.FlagType.Operand},
                new ROMByte {Rom = 0x5B, TypeFlag = Data.FlagType.Opcode},
                new ROMByte {Rom = 0x4B, TypeFlag = Data.FlagType.Opcode, DirectPage = 0x2100},
                new ROMByte {Rom = 0xAB, TypeFlag = Data.FlagType.Opcode, DirectPage = 0x2100},
                new ROMByte {Rom = 0xA2, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x07, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xBF, TypeFlag = Data.FlagType.Opcode, Point = Data.InOutPoint.InPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x32, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x9F, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x7E, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xCA, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xCA, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x10, TypeFlag = Data.FlagType.Opcode, Point = Data.InOutPoint.OutPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xF4, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x64, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x40, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x64, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x41, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x64, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x42, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x64, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x43, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xAE, TypeFlag = Data.FlagType.Opcode, Point = Data.InOutPoint.InPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xFC, TypeFlag = Data.FlagType.Opcode, Point = Data.InOutPoint.OutPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x3A, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x4C, TypeFlag = Data.FlagType.Opcode, Point = Data.InOutPoint.EndPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xC0, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Data16Bit, Point = Data.InOutPoint.ReadPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Data16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x08, TypeFlag = Data.FlagType.Data16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Data16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x10, TypeFlag = Data.FlagType.Data16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Data16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x20, TypeFlag = Data.FlagType.Data16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Data16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x44, TypeFlag = Data.FlagType.Pointer16Bit, Point = Data.InOutPoint.ReadPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x7B, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x44, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x81, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xC4, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x81, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x0A, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x82, TypeFlag = Data.FlagType.Pointer16Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x08, TypeFlag = Data.FlagType.Opcode, Point = Data.InOutPoint.InPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x8B, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x4B, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xAB, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xE2, TypeFlag = Data.FlagType.Opcode, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x20, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xC2, TypeFlag = Data.FlagType.Opcode, MFlag = true, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x10, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xA2, TypeFlag = Data.FlagType.Opcode, MFlag = true, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x1F, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xBD, TypeFlag = Data.FlagType.Opcode, MFlag = true, Point = Data.InOutPoint.InPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x5B, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x80, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x9D, TypeFlag = Data.FlagType.Opcode, MFlag = true, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x01, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xCA, TypeFlag = Data.FlagType.Opcode, MFlag = true, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x10, TypeFlag = Data.FlagType.Opcode, MFlag = true, Point = Data.InOutPoint.OutPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xF7, TypeFlag = Data.FlagType.Operand, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xAB, TypeFlag = Data.FlagType.Opcode, MFlag = true, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x28, TypeFlag = Data.FlagType.Opcode, MFlag = true, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x60, TypeFlag = Data.FlagType.Opcode, Point = Data.InOutPoint.EndPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x45, TypeFlag = Data.FlagType.Data8Bit, Point = Data.InOutPoint.ReadPoint, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x8D, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x69, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x83, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xB2, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x99, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x00, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x23, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x01, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xA3, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xF8, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x52, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x08, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xBB, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x29, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x5C, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x32, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xE7, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x88, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x3C, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x30, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x18, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x9A, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xB0, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x34, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x8C, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xDD, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x05, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0xB7, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x83, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x34, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
                new ROMByte {Rom = 0x6D, TypeFlag = Data.FlagType.Data8Bit, DataBank = 0x80, DirectPage = 0x2100},
            },
            Comments = new Dictionary<int, string>
            {
                {0x03, "this sets FastROM"},
                {0x0F, "direct page = $2100"},
                {0x21, "clear APU regs"},
                {0x44, "this routine copies Test_Data to $7E0100"}
            },
            Labels = new Dictionary<int, Label>
            {
                {0x00, new Label() {name = "Emulation_RESET", comment = "Sample emulation reset location"}},
                {0x0A, new Label() {name = "FastRESET", comment = "Sample label"}},
                {0x32, new Label() {name = "Test_Indices"}},
                {0x3A, new Label() {name = "Pointer_Table"}},
                {0x44, new Label() {name = "First_Routine"}},
                {0x5B, new Label() {name = "Test_Data", comment = "Pretty cool huh?"}}
            },
            RomMapMode = Data.ROMMapMode.LoROM,
            RomSpeed = Data.ROMSpeed.FastROM,
        };
    }
}
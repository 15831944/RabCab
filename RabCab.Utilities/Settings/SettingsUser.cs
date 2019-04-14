﻿// -----------------------------------------------------------------------------------
//     <copyright file="SettingsUser.cs" company="CraterSpace">
//     Copyright (c) 2019 CraterSpace - All Rights Reserved 
//     </copyright>
//     <author>Zach Ayers</author>
//     <date>03/08/2019</date>
//     Description:    
//     Notes:  
//     References:          
// -----------------------------------------------------------------------------------

using static RabCab.Engine.Enumerators.Enums;

namespace RabCab.Settings
{
    public static class SettingsUser
    {
        //User Options
        public static double TolPoint = 0.004;

        public static bool ManageLayers = false;
        public static bool AllowSymbols = false;
        public static bool KeepSelection = false;
        public static bool PrioritizeRightAngles = false;
        public static bool UseFields = false;
        public static RoundTolerance UserTol { set; get; } = RoundTolerance.SixDecimals;

       //SortingOptions
       public static bool SortByLayer = true;
       public static bool SortByColor = false;
       public static bool SortByThickness = true;
       public static bool SortByName = true;
       public static bool GroupSame = true;
       public static bool SplitByLayer = true;
       public static bool MixS4S = false;
    }
}
﻿using Autodesk.AutoCAD.ApplicationServices.Core;
using Autodesk.AutoCAD.Runtime;
using RabCab.Settings;
using System;
using System.Linq;

namespace RabCab.Commands.AnnotationSuite
{
    class RcDimArrow
    {
        /// <summary>
        /// </summary>
        [CommandMethod(SettingsInternal.CommandGroup, "_DIMARROW",
            CommandFlags.Modal
        //| CommandFlags.Transparent
        //| CommandFlags.UsePickSet
        //| CommandFlags.Redraw
        //| CommandFlags.NoPerspective
        //| CommandFlags.NoMultiple
        //| CommandFlags.NoTileMode
        //| CommandFlags.NoPaperSpace
        //| CommandFlags.NoOem
        //| CommandFlags.Undefined
        //| CommandFlags.InProgress
        //| CommandFlags.Defun
        //| CommandFlags.NoNewStack
        //| CommandFlags.NoInternalLock
        //| CommandFlags.DocReadLock
        //| CommandFlags.DocExclusiveLock
        //| CommandFlags.Session
        //| CommandFlags.Interruptible
        //| CommandFlags.NoHistory
        //| CommandFlags.NoUndoMarker
        //| CommandFlags.NoBlockEditor
        //| CommandFlags.NoActionRecording
        //| CommandFlags.ActionMacro
        //| CommandFlags.NoInferConstraint 
        )]
        public void Cmd_DimArrow()
        {
            //Get the current document utilities
            var acCurDoc = Application.DocumentManager.MdiActiveDocument;
            var acCurDb = acCurDoc.Database;
            var acCurEd = acCurDoc.Editor;
        }
    }
}
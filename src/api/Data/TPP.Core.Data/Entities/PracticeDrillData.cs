// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace TPP.Core.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PracticeDrillData : EntityBase
    {
        [ForeignKey("Practice")]
        public int PracticeId { get; set; }

        [ForeignKey("PracticeDrill")]
        public Nullable<int> PracticeDrillId { get; set; }

        public bool isModified { get; set; }
        public Nullable<decimal> Duration { get; set; }
        public string DrillArea { get; set; }
        public Nullable<int> DrillLength { get; set; }
        public Nullable<int> DrillWidth { get; set; }
        public Nullable<int> NumberOfPlayers { get; set; }
        public Nullable<int> CalculatedTrainingLoad { get; set; }
        [ForeignKey("Note")]
        public Nullable<int> NoteId { get; set; }

        //Navigation properties
        public Practice Practice { get; set; }
        public PracticeDrill PracticeDrill { get; set; }
        public Note Note { get; set; }

    }
}
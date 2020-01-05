﻿using ComedyHub.Model.Meme;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComedyHub.Core.Components.Contracts
{
    public interface INineGagComponent
    {

        Task<MemeModel> GetNineGagMeme();
    }
}

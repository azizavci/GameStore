﻿using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);

    }
}

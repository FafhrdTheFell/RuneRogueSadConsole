﻿namespace RuneRogueSadConsole.Interfaces
{
   public interface IItem
   {
      string Name { get; }
      int RemainingUses { get; }

      bool Use();
   }
}

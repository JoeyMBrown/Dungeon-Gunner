using UnityEngine;

public static class Settings
{
    #region ROOM SETTINGS

    // Maximum number of child corridors leading from a room
    // Maximum should be 3 although this is not recommended
    // as it can cause teh dungeon building to fail since the
    // rooms are more likely to not fit together.
    public const int maxChildCorridors = 3;
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundSettings
{
    public const float MIN_LEVEL_SOUND = 0;
    public const float MAX_LEVEL_SOUND = 1;

    private static float _musicLevel = 0.75f;
    private static float _fxLevel = 0.50f;

    public static float MusicLevel
    {
        get
        {
            return _musicLevel;
        }
        set
        {
            if (value < MIN_LEVEL_SOUND)
            {
                _musicLevel = MIN_LEVEL_SOUND;
            }
            else if (value > MAX_LEVEL_SOUND)
            {
                _musicLevel = MAX_LEVEL_SOUND;
            }
            else
            {
                _musicLevel = value;
            }
        }
    }

    public static float FXLevel
    {
        get
        {
            return _fxLevel;
        }
        set
        {
            if (value < MIN_LEVEL_SOUND)
            {
                _fxLevel = MIN_LEVEL_SOUND;
            }
            else if (value > MAX_LEVEL_SOUND)
            {
                _fxLevel = MAX_LEVEL_SOUND;
            }
            else
            {
                _fxLevel = value;
            }
        }
    }

   
}

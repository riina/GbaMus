﻿using GbaMus;

try
{
    return SoundFontRipper.Main(args);
}
catch (EnvironmentExitException e)
{
    return e.Code;
}

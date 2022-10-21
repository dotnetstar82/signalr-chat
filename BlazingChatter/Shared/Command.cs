﻿using BlazingChatter.Enums;

namespace BlazingChatter.Records
{
    public record Command(
        JokeType JokeType,
        BotCommand BotCommand,
        string Language)
    {
        public static implicit operator Command(
            (JokeType Type, BotCommand Command, string Lang) tuple) =>
            new(tuple.Type, tuple.Command, tuple.Lang);
    }
}

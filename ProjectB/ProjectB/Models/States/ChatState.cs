﻿using Newtonsoft.Json;
using ProjectB.Models.States.Enums;
using System;
using System.ComponentModel.DataAnnotations;


namespace ProjectB.Models.States
{
    public class ChatState
    {
        public ChatState(long chatId, ContextState state = ContextState.MainState)
        {
            Id = Guid.NewGuid().ToString();
            Chat_Id = chatId;
            Current_State = state;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [Required]
        [JsonProperty("chat_id")]
        public long Chat_Id { get; set; }

        [Required]
        [JsonProperty("current_state")]
        public ContextState Current_State { get; set; }
    }
}

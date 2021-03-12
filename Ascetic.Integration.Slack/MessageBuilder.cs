﻿using Ascetic.Integration.Slack.Models;
using System;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack
{
    public static class MessageBuilder
    {
        public static SlackMessage CreateMessage(string text = default)
        {
            return new SlackMessage
            {
                Text = text
            };
        }

        public static SlackMessage AddAttachment(this SlackMessage message, Func<SlackAttachment, SlackAttachment> attachmentBuilder)
        {
            if (message.Attachments == null)
            {
                message.Attachments = new List<SlackAttachment>();
            }
            var attachment = attachmentBuilder(new SlackAttachment());
            message.Attachments.Add(attachment);
            return message;
        }

        public static SlackAttachment AddField(this SlackAttachment attachment, string title, string value, bool isShort = false)
        {
            if (attachment.Fields == null)
            {
                attachment.Fields = new List<SlackField>();
            }
            attachment.Fields.Add(new SlackField 
            { 
                Title = title, 
                Value = value, 
                Short = isShort 
            });
            return attachment;
        }

        public static SlackAttachment SetAuthor(this SlackAttachment attachment, string authorName, string authorLink = default, string authorIcon = default)
        {
            attachment.AuthorName = authorName;
            attachment.AuthorLink = authorLink;
            attachment.AuthorIcon = authorIcon;
            return attachment;
        }

        public static SlackAttachment SetTitle(this SlackAttachment attachment, string title, string titleLink = default)
        {
            attachment.Title = title;
            attachment.TitleLink = titleLink;
            return attachment;
        }

        public static SlackAttachment SetText(this SlackAttachment attachment, string text, string pretext = default)
        {
            attachment.Text = text;
            attachment.Pretext = pretext;
            return attachment;
        }

        public static SlackAttachment SetFooter(this SlackAttachment attachment, string footer, string footerIcon = default)
        {
            attachment.Footer = footer;
            attachment.FooterIcon = footerIcon;
            return attachment;
        }

        public static SlackAttachment SetSuccessStatus(this SlackAttachment attachment)
        {
            attachment.Color = "#28a745";
            return attachment;
        }

        public static SlackAttachment SetWarningStatus(this SlackAttachment attachment)
        {
            attachment.Color = "#ffc107";
            return attachment;
        }

        public static SlackAttachment SetDangerStatus(this SlackAttachment attachment)
        {
            attachment.Color = "#dc3545";
            return attachment;
        }
    }
}

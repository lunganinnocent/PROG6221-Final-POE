using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROG6221
{
    public partial class Form3 : Form
    {

        private static string userName = "";
        private static string favoriteTopic = "";
        private static bool awaitingUserName = true;
        private static bool awaitingFavoriteTopic = false;
        private static bool awaitingEmotion = false;
        private static bool awaitingContinueChat = false;

        private static Random rand = new Random();

        private static Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>()
        {
            { "password", new List<string>() {
                "Use strong, unique passwords for each account.",
                "Avoid using personal details in your passwords.",
                "Consider using a password manager to keep track of complex passwords."
            }},
            { "scam", new List<string>() {
                "Scammers often impersonate trusted organizations. Always verify before responding.",
                "Don't click on suspicious links or attachments from unknown sources.",
                "Check for spelling and grammar errors, which are common in scam messages."
            }},
            { "privacy", new List<string>() {
                "Regularly review privacy settings on social media.",
                "Limit what personal information you share online.",
                "Use encrypted messaging apps for sensitive communication."
            }},
            { "phishing", new List<string>() {
                "Be cautious of emails asking for personal info.",
                "Check sender addresses and avoid clicking suspicious links.",
                "Phishing emails often create a sense of urgency to trick you."
            }}
        };

        private static Dictionary<string, string> emotionResponses = new Dictionary<string, string>()
        {
            { "worried", "It's completely understandable to feel that way. Let me help you stay safe. :)" },
            { "curious", "I love your curiosity! Let's explore more about this topic together. :)" },
            { "frustrated", "I know it can be confusing, but don't worry, you're doing great learning this stuff. :)" },
            { "happy", "I'm glad you're feeling good! Cybersecurity can be empowering. :)" },
            { "sad", "I'm here to support you. Let's focus on learning how to stay secure." },
            { "angry", "It's okay to be upset. Let's figure out how to prevent issues together." }
        };

        private static Dictionary<string, string> emotionKeywords = new Dictionary<string, string>()
        {
            { "anxious", "worried" },
            { "nervous", "worried" },
            { "confused", "frustrated" },
            { "irritated", "frustrated" },
            { "mad", "angry" },
            {"angry","angry" },
            {"sad","sad" },
            {"unhappy","sad" },
            {"happy","happy" },
            {"exited","happy" }, // Typo "exited" -> "excited"
            {"interested","curious" },
            {"curious","curious" },
            {"worried","worried" },
            {"frustrated","frustrated" } // Corrected from "worried" to "frustrated"
        };


        public Form3()
        {
            InitializeComponent();
            DisplayBotMessage("Welcome to the Cybersecurity Chatbot!");
            DisplayBotMessage("My name is CyberBot. What's your name?");
            // Set initial state to await user name
            awaitingUserName = true;
            awaitingFavoriteTopic = false;
            awaitingEmotion = false;
            awaitingContinueChat = false;
        }

        private void AppendToChatHistory(string message, bool isUser)
        {
            string prefix = isUser ? "You: " : "CyberBot: ";
            rtbChatHistory.AppendText(prefix + message + Environment.NewLine);
            // Auto-scroll to the bottom
            rtbChatHistory.SelectionStart = rtbChatHistory.Text.Length;
            rtbChatHistory.ScrollToCaret();
        }

        private void DisplayBotMessage(string message)
        {
            AppendToChatHistory(message, false);
        }

        private void ProcessUserInput(string input)
        {
            AppendToChatHistory(input, true); // Display user's message

            string processedInput = input.ToLower().Trim();

            if (awaitingUserName)
            {
                userName = input;
                DisplayBotMessage($"Nice to meet you, {userName}! What's your favorite cybersecurity topic? (e.g., password, scam, privacy, phishing)");
                awaitingUserName = false;
                awaitingFavoriteTopic = true;
            }
            else if (awaitingFavoriteTopic)
            {
                favoriteTopic = processedInput;
                if (keywordResponses.ContainsKey(favoriteTopic))
                {
                    DisplayBotMessage($"Great! Here's some information about {favoriteTopic}:");
                    foreach (string response in keywordResponses[favoriteTopic])
                    {
                        DisplayBotMessage($"- {response}");
                    }
                }
                else
                {
                    DisplayBotMessage($"I'm sorry, I don't have specific information about '{favoriteTopic}'. However, I can still help you with other cybersecurity topics.");
                }
                DisplayBotMessage("How are you feeling today? (e.g., worried, curious, frustrated, happy, sad, angry)");
                awaitingFavoriteTopic = false;
                awaitingEmotion = true;
            }
            else if (awaitingEmotion)
            {
                string userEmotionKey = processedInput;
                if (emotionKeywords.ContainsKey(userEmotionKey))
                {
                    userEmotionKey = emotionKeywords[userEmotionKey];
                }

                if (emotionResponses.ContainsKey(userEmotionKey))
                {
                    DisplayBotMessage(emotionResponses[userEmotionKey]);
                }
                else
                {
                    DisplayBotMessage("Thanks for sharing your feelings. I'm here to help you with cybersecurity.");
                }
                DisplayBotMessage("Is there anything else I can help you with? (yes/no)");
                awaitingEmotion = false;
                awaitingContinueChat = true;
            }
            else if (awaitingContinueChat)
            {
                if (processedInput == "yes")
                {
                    DisplayBotMessage("What else can I help you with? (e.g., password, scam, privacy, phishing)");
                    // Reset flags to allow for topic input again
                    awaitingContinueChat = false;
                }
                else if (processedInput == "no")
                {
                    DisplayBotMessage("Thank you for chatting with me! Stay safe online!");
                    // Disable input fields to indicate chat end
                    txtUserInput.Enabled = false;
                    btnSend.Enabled = false;
                }
                else
                {
                    DisplayBotMessage("Please answer with 'yes' or 'no'.");
                }
            }
            else // This is for general topic queries after the initial flow
            {
                if (keywordResponses.ContainsKey(processedInput))
                {
                    DisplayBotMessage($"Here's some information about {processedInput}:");
                    foreach (string response in keywordResponses[processedInput])
                    {
                        DisplayBotMessage($"- {response}");
                    }
                }
                else
                {
                    DisplayBotMessage($"I'm sorry, I don't have specific information about '{processedInput}'. I can still help with topics like password, scam, privacy, or phishing.");
                }
                DisplayBotMessage("Is there anything else I can help you with? (yes/no)");
                awaitingContinueChat = true; // Set flag to expect yes/no
            }

            txtUserInput.Clear(); // Clear the input box for the next message
            txtUserInput.Focus(); // Keep focus on the input box
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserInput.Text))
            {
                ProcessUserInput(txtUserInput.Text);
            }
        }

        private void txtUserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Consume the Enter key press
                btnSend.PerformClick(); // Simulate a click on the Send button
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}

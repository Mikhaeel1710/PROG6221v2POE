using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progPOEv3
{
    class Answers
    {
        public static string passwordSafety()
        {
            Random random = new Random();
            int num = random.Next(1, 4);// chooses random answer to give, providing diversity.
            if (num == 1)
            {
                return ("To stay safe online, prioritize strong password practices. " +
                    "Passwords should be at least 12 characters long and incorporate a mix of uppercase and lowercase letters, numbers, and symbols. " +
                    "Avoid reusing passwords across different accounts, as a breach in one could compromise all. " +
                    "Utilize password managers to generate and securely store unique passwords, simplifying management and enhancing security. " +
                    "Implement two-factor authentication (2FA) whenever possible for an extra layer of protection. " +
                    "Regularly update passwords, especially for sensitive accounts, and be vigilant against phishing attempts. " +
                    "By following these guidelines, you significantly reduce your risk of online threats and protect your valuable information.");
            }
            else
            {
                if (num == 2)
                {
                    return ("Safeguarding your online accounts begins with strong password habits. " +
                   "Aim for passwords that are lengthy, ideally exceeding 12 characters, and combine a variety of elements: uppercase and lowercase letters, numbers, and special characters like \"!@#$\". " +
                   "Think of a memorable phrase and then modify it, for example, \"MyFavoriteColorIsBlue123!\" becomes \"M!f@v0r!t3C0l0r!sBlU3\". " +
                   "Avoid reusing passwords across different platforms; a breach on one site shouldn't compromise your banking or email. " +
                   "Utilize password managers to generate, store, and automatically fill in complex, unique passwords for each site. " +
                   "Enable two-factor authentication (2FA) wherever offered – it's like having a second lock on your digital door. " +
                   "Be wary of phishing scams: never share your passwords in emails or on suspicious websites. By following these practices, you'll create a much more secure digital environment.");
                }
                else
                {
                    return ("In today's interconnected world, strong passwords are paramount for protecting your digital identity. " +
                         "The foundation of online security lies in creating passwords that are both long and complex, employing a mix of characters and avoiding easily guessable patterns. " +
                         "Think of it like building a strong fortress: the longer and more intricate the defenses, the harder it is to breach. " +
                         "Never reuse passwords, as this creates a domino effect if one account is compromised. " +
                         "Consider a password manager as your personal security guard, generating and storing unique passwords for each site. " +
                         "Enable two-factor authentication (2FA) whenever available, adding an extra layer of verification. " +
                         "Regularly review and update your passwords, especially for sensitive accounts, and stay vigilant against phishing attempts. " +
                         "By embracing these essential security measures, you're not just protecting your accounts, you're safeguarding your personal information and privacy in the digital age.");
                }

            }

        }
        public static string Phishingsafety()
        {

            Random random = new Random();
            int num = random.Next(1, 4);// chooses random answer to give, providing diversity.
            if (num == 1)
            {
                return ("Phishing scams are a common threat, but you can significantly reduce your risk by staying vigilant. Always scrutinize emails and messages before clicking any links or downloading attachments. " +
                    "Look closely at the sender's email address; if it seems suspicious or doesn't match the purported sender, it's likely a phishing attempt. " +
                    "Hover your mouse over links to preview the destination URL before clicking – if it's not what you expect, don't click it. " +
                    "Never provide personal information like passwords, bank details, or social security numbers in response to unsolicited emails or messages. " +
                    "Be especially wary of urgent requests or threats, as these are often used to pressure you into acting quickly. Instead of clicking a link in an email, go directly to the website by typing the address in your browser. " +
                    "By being cautious and questioning everything, you can protect yourself from these scams.");
            }
            else
            {
                if (num == 2)
                {
                    return ("Phishing attacks prey on human trust and urgency. Cybercriminals craft deceptive emails and messages that mimic legitimate organizations to trick you into revealing sensitive information. " +
                        "Recognize the psychological tactics: urgent deadlines, threats of account suspension, or too-good-to-be-true offers. Be skeptical of any communication that asks for personal data, especially passwords or financial details. " +
                        "Always verify the sender's identity by contacting the organization directly through a known phone number or website, rather than relying on the contact information provided in the suspicious message." +
                        " Look for grammatical errors or unprofessional language, which are often telltale signs of a phishing attempt. Trust your instincts: if something feels off, it probably is. " +
                        "By understanding the psychology behind phishing and learning to identify red flags, you can significantly reduce your vulnerability.");
                }
                else
                {
                    return ("Avoiding phishing requires a proactive approach to online security. Start by educating yourself about common phishing tactics and staying informed about the latest scams. " +
                        "Install and maintain robust antivirus software and keep your operating system and web browser updated to protect against malware and vulnerabilities. " +
                        "Use strong passwords and enable two-factor authentication (2FA) on all your important accounts. Regularly review your online accounts for suspicious activity and monitor your financial statements for unauthorized transactions." +
                        " Consider using a spam filter and be cautious about clicking on links or downloading attachments from unknown senders. " +
                        "Treat every email and message with a degree of skepticism, and always double-check the sender's identity before taking any action." +
                        " By adopting these long-term security habits, you can build a strong defense against phishing attacks and protect your digital life.");
                }
            }
        }
        public static string safebrowsing()
        {
            Random random = new Random();
            int num = random.Next(1, 4);// chooses random answer to give, providing diversity.
            if (num == 1)
            {
                return ("To browse safely online, start by configuring your web browser for optimal security. Enable security features like \"Do Not Track\" and consider using a privacy-focused search engine. " +
                    "Keep your browser updated to the latest version to patch security vulnerabilities. Be cautious about the websites you visit; look for \"https\" in the address bar, indicating a secure connection. " +
                    "Avoid clicking on suspicious links or downloading files from untrusted sources. Regularly clear your browsing history, cookies, and cache to minimize the tracking of your online activity. " +
                    "Use a pop-up blocker to prevent unwanted ads and potential malware infections. Consider using a virtual private network (VPN) to encrypt your internet traffic and protect your privacy, especially when using public Wi-Fi. " +
                    "By implementing these browser settings and practicing safe browsing habits, you can significantly reduce your exposure to online threats.");
            }
            else
            {
                if (num == 2)
                {
                    return ("Safe browsing is about being aware of the risks and taking proactive steps to mitigate them. Be skeptical of sensational headlines, clickbait, and offers that seem too good to be true. " +
                        "Before entering any personal information, carefully examine the website's URL and ensure it's legitimate. Avoid visiting websites that are known for distributing malware or engaging in deceptive practices. " +
                        "Pay attention to the website's design and content: if it looks unprofessional or contains numerous grammatical errors, it may be a sign of a malicious site. " +
                        "Be wary of online quizzes or surveys that ask for excessive personal information. Regularly review your online accounts for any unauthorized activity. " +
                        "Trust your instincts: if a website or online interaction feels suspicious, it's best to err on the side of caution and avoid it. By cultivating a sense of awareness and critical thinking, you can navigate the web safely.");
                }
                else
                {
                    return ("Protecting your devices is essential for safe browsing. Install a reputable antivirus program and keep it updated to detect and remove malware. " +
                        "Regularly scan your computer for viruses and other threats. Enable a firewall to block unauthorized access to your device. " +
                        "Be cautious about downloading software from untrusted sources; stick to official app stores and websites. Keep your operating system and all your software up-to-date with the latest security patches. " +
                        "Avoid clicking on links or opening attachments from unknown senders, as these can contain malware. Consider using a password manager to securely store your login credentials and prevent them from being compromised. " +
                        "Regularly back up your important files to protect against data loss. By prioritizing software and device security, you create a strong foundation for safe and secure browsing.");
                }
            }
        }
        public static string watchpost()
        {
            Random random = new Random();
            int num = random.Next(1, 4);// chooses random answer to give, providing diversity.
            if (num == 1)
            {
                return ("To stay safe online, be incredibly mindful of what you share. Avoid posting any personally identifiable information (PII), such as your full name, address, phone number, date of birth, or the names of your children's schools." +
                    " Think carefully before sharing your location, especially in real-time. Be wary of posting vacation plans or details about your daily routines, as this information could be used by malicious actors. " +
                    "Review your privacy settings on all social media platforms and ensure that your posts are visible only to the intended audience. " +
                    "Consider using different profiles for different purposes, such as a professional profile and a personal profile. Remember that once something is posted online, it can be difficult to remove entirely. " +
                    "By carefully curating your online presence and limiting the sharing of PII, you significantly reduce your risk of identity theft, stalking, and other online threats");
            }
            else
            {
                if (num == 2)
                {
                    return ("Your online posts can have a lasting impact on your reputation and future opportunities. Before posting anything, consider how it might be perceived by potential employers, friends, family, or even strangers. " +
                        "Avoid posting anything that could be considered offensive, discriminatory, or illegal. Be mindful of the tone and language you use, and avoid engaging in online arguments or spreading misinformation. " +
                        "Think twice before sharing sensitive or controversial opinions, as these could be misinterpreted or used against you. " +
                        "Regularly review your online presence and remove any content that you no longer want associated with your name. Use Google Alerts to monitor your name and see what information is available about you online. " +
                        "By carefully managing your online reputation and curating your content, you can protect your personal and professional interests.");
                }
                else
                {
                    return ("Everything you post online contributes to your digital footprint, which is the trail of data you leave behind as you use the internet. " +
                        "This footprint can be used to track your activities, preferences, and even your location. Be aware of the broader context of your posts and how they might be used by others. " +
                        "Avoid sharing anything that could be used to identify or target you, such as photos of your home or car. Be cautious about tagging yourself or others in photos, as this can reveal your location and associations. " +
                        "Consider the privacy implications of sharing information about your friends and family. Regularly review your social media accounts and delete any old or irrelevant posts." +
                        " Use strong privacy settings on all your accounts and be mindful of the information you are sharing. " +
                        "By understanding the concept of your digital footprint and taking steps to minimize its impact, you can protect your privacy and safety online.");
                }
            }
        }
    }
}

    

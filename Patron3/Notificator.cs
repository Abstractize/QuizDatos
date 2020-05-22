public class Notificator
{
    public List<Profile> profiles = new List<Profile>();
    public void AddProfile(Profile Profile)
    {
        profiles.Add(Profile);
    }
    public void Notify(Message message)
    {
        foreach (Profile obs in profiles)
        {
            obs.GetNotified(message);
        }
    }
    public void NotifyOnly(Message message, Profile profile)
    {
        profile.GetNotified(message);
    }
    public void NotifyAllBut(Message message, Profile Profile)
    {
        foreach (Profile obs in profiles)
        {
            if (obs != Profile)
                obs.GetNotified(message);
        }
    }
}
public struct Message
{
    public string message;
    public string nameFrom;
}
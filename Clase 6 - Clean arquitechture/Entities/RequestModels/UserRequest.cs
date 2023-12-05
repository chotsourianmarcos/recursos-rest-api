using Entities.Items;

namespace Entities.RequestModels
{
    public class NewUserRequest
    {
        public string UserName { get; set; } = "";
        public string UserEmail { get; set; } = "";
        public int PersonId { get; set; }
        public PersonItem? Person { get; set; }
        public List<ActivityItem>? Activities { get; set; }
        public UserItem ToUserItem()
        {
            var userItem = new UserItem();

            userItem.UserName = UserName;
            userItem.UserEmail = UserEmail;
            if(PersonId > 0)
            {
                userItem.PersonId = PersonId;
            }
            else if(Person != null)
            {
                userItem.Person = Person;
            }

            if(Activities != null)
            {
                userItem.Activities = Activities;
            }

            return userItem;
        }
    }
}
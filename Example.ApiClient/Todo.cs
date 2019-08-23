using Newtonsoft.Json;

namespace Example.ApiClient
{
    public class Todo
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        [JsonProperty("userId")]
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Example.ApiClient.Todo"/> is completed.
        /// </summary>
        /// <value><c>true</c> if completed; otherwise, <c>false</c>.</value>
        [JsonProperty("completed")]
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"\nuserId:{UserId}\nid:{Id}\ntitle:{Title}\ncompleted:{Completed}";
        }
        
    }
}

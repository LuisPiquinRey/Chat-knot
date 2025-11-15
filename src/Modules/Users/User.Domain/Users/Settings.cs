namespace User.Domain.Users;

/*
 * This is a value object. It is identified by the values it contains,
 * which means that even if two users have value objects with the same
 * values, they are considered the same. A value object can also have a single element.
*/
public record Settings(
    string Language,
    bool NotificationsEnabled,
    bool EmailNotificationsEnabled
);

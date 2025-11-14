namespace User.Domain.Users;

public record Settings(
    string Language,
    bool NotificationsEnabled,
    bool EmailNotificationsEnabled
);

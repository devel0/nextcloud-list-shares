using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class CloudContext : DbContext
{
    public CloudContext()
    {
    }

    public CloudContext(DbContextOptions<CloudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OcAccount> OcAccounts { get; set; }

    public virtual DbSet<OcAccountsDatum> OcAccountsData { get; set; }

    public virtual DbSet<OcActivity> OcActivities { get; set; }

    public virtual DbSet<OcActivityMq> OcActivityMqs { get; set; }

    public virtual DbSet<OcAddressbook> OcAddressbooks { get; set; }

    public virtual DbSet<OcAddressbookchange> OcAddressbookchanges { get; set; }

    public virtual DbSet<OcAppconfig> OcAppconfigs { get; set; }

    public virtual DbSet<OcAuthorizedGroup> OcAuthorizedGroups { get; set; }

    public virtual DbSet<OcAuthtoken> OcAuthtokens { get; set; }

    public virtual DbSet<OcBruteforceAttempt> OcBruteforceAttempts { get; set; }

    public virtual DbSet<OcCalendar> OcCalendars { get; set; }

    public virtual DbSet<OcCalendarInvitation> OcCalendarInvitations { get; set; }

    public virtual DbSet<OcCalendarReminder> OcCalendarReminders { get; set; }

    public virtual DbSet<OcCalendarResource> OcCalendarResources { get; set; }

    public virtual DbSet<OcCalendarResourcesMd> OcCalendarResourcesMds { get; set; }

    public virtual DbSet<OcCalendarRoom> OcCalendarRooms { get; set; }

    public virtual DbSet<OcCalendarRoomsMd> OcCalendarRoomsMds { get; set; }

    public virtual DbSet<OcCalendarchange> OcCalendarchanges { get; set; }

    public virtual DbSet<OcCalendarobject> OcCalendarobjects { get; set; }

    public virtual DbSet<OcCalendarobjectsProp> OcCalendarobjectsProps { get; set; }

    public virtual DbSet<OcCalendarsubscription> OcCalendarsubscriptions { get; set; }

    public virtual DbSet<OcCard> OcCards { get; set; }

    public virtual DbSet<OcCardsProperty> OcCardsProperties { get; set; }

    public virtual DbSet<OcCirclesCircle> OcCirclesCircles { get; set; }

    public virtual DbSet<OcCirclesEvent> OcCirclesEvents { get; set; }

    public virtual DbSet<OcCirclesMember> OcCirclesMembers { get; set; }

    public virtual DbSet<OcCirclesMembership> OcCirclesMemberships { get; set; }

    public virtual DbSet<OcCirclesMount> OcCirclesMounts { get; set; }

    public virtual DbSet<OcCirclesMountpoint> OcCirclesMountpoints { get; set; }

    public virtual DbSet<OcCirclesRemote> OcCirclesRemotes { get; set; }

    public virtual DbSet<OcCirclesShareLock> OcCirclesShareLocks { get; set; }

    public virtual DbSet<OcCirclesToken> OcCirclesTokens { get; set; }

    public virtual DbSet<OcCollresAccesscache> OcCollresAccesscaches { get; set; }

    public virtual DbSet<OcCollresCollection> OcCollresCollections { get; set; }

    public virtual DbSet<OcCollresResource> OcCollresResources { get; set; }

    public virtual DbSet<OcComment> OcComments { get; set; }

    public virtual DbSet<OcCommentsReadMarker> OcCommentsReadMarkers { get; set; }

    public virtual DbSet<OcDavAbsence> OcDavAbsences { get; set; }

    public virtual DbSet<OcDavCalProxy> OcDavCalProxies { get; set; }

    public virtual DbSet<OcDavShare> OcDavShares { get; set; }

    public virtual DbSet<OcDirectEdit> OcDirectEdits { get; set; }

    public virtual DbSet<OcDirectlink> OcDirectlinks { get; set; }

    public virtual DbSet<OcFederatedReshare> OcFederatedReshares { get; set; }

    public virtual DbSet<OcFileLock> OcFileLocks { get; set; }

    public virtual DbSet<OcFilecache> OcFilecaches { get; set; }

    public virtual DbSet<OcFilecacheExtended> OcFilecacheExtendeds { get; set; }

    public virtual DbSet<OcFilesMetadataIndex> OcFilesMetadataIndices { get; set; }

    public virtual DbSet<OcFilesMetadatum> OcFilesMetadata { get; set; }

    public virtual DbSet<OcFilesReminder> OcFilesReminders { get; set; }

    public virtual DbSet<OcFilesTrash> OcFilesTrashes { get; set; }

    public virtual DbSet<OcFilesVersion> OcFilesVersions { get; set; }

    public virtual DbSet<OcFlowCheck> OcFlowChecks { get; set; }

    public virtual DbSet<OcFlowOperation> OcFlowOperations { get; set; }

    public virtual DbSet<OcFlowOperationsScope> OcFlowOperationsScopes { get; set; }

    public virtual DbSet<OcGroup> OcGroups { get; set; }

    public virtual DbSet<OcGroupAdmin> OcGroupAdmins { get; set; }

    public virtual DbSet<OcGroupUser> OcGroupUsers { get; set; }

    public virtual DbSet<OcJob> OcJobs { get; set; }

    public virtual DbSet<OcKnownUser> OcKnownUsers { get; set; }

    public virtual DbSet<OcLoginFlowV2> OcLoginFlowV2s { get; set; }

    public virtual DbSet<OcMigration> OcMigrations { get; set; }

    public virtual DbSet<OcMimetype> OcMimetypes { get; set; }

    public virtual DbSet<OcMount> OcMounts { get; set; }

    public virtual DbSet<OcNotification> OcNotifications { get; set; }

    public virtual DbSet<OcNotificationsPushhash> OcNotificationsPushhashes { get; set; }

    public virtual DbSet<OcNotificationsSetting> OcNotificationsSettings { get; set; }

    public virtual DbSet<OcOauth2AccessToken> OcOauth2AccessTokens { get; set; }

    public virtual DbSet<OcOauth2Client> OcOauth2Clients { get; set; }

    public virtual DbSet<OcOpenLocalEditor> OcOpenLocalEditors { get; set; }

    public virtual DbSet<OcPhotosAlbum> OcPhotosAlbums { get; set; }

    public virtual DbSet<OcPhotosAlbumsCollab> OcPhotosAlbumsCollabs { get; set; }

    public virtual DbSet<OcPhotosAlbumsFile> OcPhotosAlbumsFiles { get; set; }

    public virtual DbSet<OcPreference> OcPreferences { get; set; }

    public virtual DbSet<OcPrivacyAdmin> OcPrivacyAdmins { get; set; }

    public virtual DbSet<OcProfileConfig> OcProfileConfigs { get; set; }

    public virtual DbSet<OcProperty> OcProperties { get; set; }

    public virtual DbSet<OcRatelimitEntry> OcRatelimitEntries { get; set; }

    public virtual DbSet<OcReaction> OcReactions { get; set; }

    public virtual DbSet<OcRecentContact> OcRecentContacts { get; set; }

    public virtual DbSet<OcSchedulingobject> OcSchedulingobjects { get; set; }

    public virtual DbSet<OcShare> OcShares { get; set; }

    public virtual DbSet<OcShareExternal> OcShareExternals { get; set; }

    public virtual DbSet<OcSharesLimit> OcSharesLimits { get; set; }

    public virtual DbSet<OcStorage> OcStorages { get; set; }

    public virtual DbSet<OcStoragesCredential> OcStoragesCredentials { get; set; }

    public virtual DbSet<OcSystemtag> OcSystemtags { get; set; }

    public virtual DbSet<OcSystemtagGroup> OcSystemtagGroups { get; set; }

    public virtual DbSet<OcSystemtagObjectMapping> OcSystemtagObjectMappings { get; set; }

    public virtual DbSet<OcText2imageTask> OcText2imageTasks { get; set; }

    public virtual DbSet<OcTextDocument> OcTextDocuments { get; set; }

    public virtual DbSet<OcTextSession> OcTextSessions { get; set; }

    public virtual DbSet<OcTextStep> OcTextSteps { get; set; }

    public virtual DbSet<OcTextprocessingTask> OcTextprocessingTasks { get; set; }

    public virtual DbSet<OcTrustedServer> OcTrustedServers { get; set; }

    public virtual DbSet<OcTwofactorBackupcode> OcTwofactorBackupcodes { get; set; }

    public virtual DbSet<OcTwofactorProvider> OcTwofactorProviders { get; set; }

    public virtual DbSet<OcUser> OcUsers { get; set; }

    public virtual DbSet<OcUserStatus> OcUserStatuses { get; set; }

    public virtual DbSet<OcUserTransferOwner> OcUserTransferOwners { get; set; }

    public virtual DbSet<OcVcategory> OcVcategories { get; set; }

    public virtual DbSet<OcVcategoryToObject> OcVcategoryToObjects { get; set; }

    public virtual DbSet<OcWebauthn> OcWebauthns { get; set; }

    public virtual DbSet<OcWhatsNew> OcWhatsNews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:Cloud");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OcAccount>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("oc_accounts_pkey");

            entity.ToTable("oc_accounts");

            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("''::text")
                .HasColumnName("data");
        });

        modelBuilder.Entity<OcAccountsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_accounts_data_pkey");

            entity.ToTable("oc_accounts_data");

            entity.HasIndex(e => e.Name, "accounts_data_name");

            entity.HasIndex(e => e.Uid, "accounts_data_uid");

            entity.HasIndex(e => e.Value, "accounts_data_value");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasColumnName("uid");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcActivity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("oc_activity_pkey");

            entity.ToTable("oc_activity");

            entity.HasIndex(e => new { e.Affecteduser, e.Type, e.App, e.Timestamp }, "activity_filter");

            entity.HasIndex(e => new { e.Affecteduser, e.User, e.Timestamp }, "activity_filter_by");

            entity.HasIndex(e => new { e.ObjectType, e.ObjectId }, "activity_object");

            entity.HasIndex(e => new { e.Affecteduser, e.Timestamp }, "activity_user_time");

            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Affecteduser)
                .HasMaxLength(64)
                .HasColumnName("affecteduser");
            entity.Property(e => e.App)
                .HasMaxLength(32)
                .HasColumnName("app");
            entity.Property(e => e.File)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("file");
            entity.Property(e => e.Link)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("link");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("message");
            entity.Property(e => e.Messageparams).HasColumnName("messageparams");
            entity.Property(e => e.ObjectId)
                .HasDefaultValue(0L)
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("object_type");
            entity.Property(e => e.Priority)
                .HasDefaultValue(0)
                .HasColumnName("priority");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("subject");
            entity.Property(e => e.Subjectparams).HasColumnName("subjectparams");
            entity.Property(e => e.Timestamp)
                .HasDefaultValue(0)
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("type");
            entity.Property(e => e.User)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("user");
        });

        modelBuilder.Entity<OcActivityMq>(entity =>
        {
            entity.HasKey(e => e.MailId).HasName("oc_activity_mq_pkey");

            entity.ToTable("oc_activity_mq");

            entity.HasIndex(e => e.AmqLatestSend, "amp_latest_send_time");

            entity.HasIndex(e => e.AmqTimestamp, "amp_timestamp_time");

            entity.HasIndex(e => e.AmqAffecteduser, "amp_user");

            entity.Property(e => e.MailId).HasColumnName("mail_id");
            entity.Property(e => e.AmqAffecteduser)
                .HasMaxLength(64)
                .HasColumnName("amq_affecteduser");
            entity.Property(e => e.AmqAppid)
                .HasMaxLength(32)
                .HasColumnName("amq_appid");
            entity.Property(e => e.AmqLatestSend)
                .HasDefaultValue(0)
                .HasColumnName("amq_latest_send");
            entity.Property(e => e.AmqSubject)
                .HasMaxLength(255)
                .HasColumnName("amq_subject");
            entity.Property(e => e.AmqSubjectparams).HasColumnName("amq_subjectparams");
            entity.Property(e => e.AmqTimestamp)
                .HasDefaultValue(0)
                .HasColumnName("amq_timestamp");
            entity.Property(e => e.AmqType)
                .HasMaxLength(255)
                .HasColumnName("amq_type");
            entity.Property(e => e.ObjectId)
                .HasDefaultValue(0L)
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("object_type");
        });

        modelBuilder.Entity<OcAddressbook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_addressbooks_pkey");

            entity.ToTable("oc_addressbooks");

            entity.HasIndex(e => new { e.Principaluri, e.Uri }, "addressbook_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("description");
            entity.Property(e => e.Displayname)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("displayname");
            entity.Property(e => e.Principaluri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("principaluri");
            entity.Property(e => e.Synctoken)
                .HasDefaultValue(1)
                .HasColumnName("synctoken");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcAddressbookchange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_addressbookchanges_pkey");

            entity.ToTable("oc_addressbookchanges");

            entity.HasIndex(e => new { e.Addressbookid, e.Synctoken }, "addressbookid_synctoken");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addressbookid).HasColumnName("addressbookid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValue(0)
                .HasColumnName("created_at");
            entity.Property(e => e.Operation).HasColumnName("operation");
            entity.Property(e => e.Synctoken)
                .HasDefaultValue(1)
                .HasColumnName("synctoken");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcAppconfig>(entity =>
        {
            entity.HasKey(e => new { e.Appid, e.Configkey }).HasName("oc_appconfig_pkey");

            entity.ToTable("oc_appconfig");

            entity.HasIndex(e => e.Lazy, "ac_lazy_i");

            entity.Property(e => e.Appid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("appid");
            entity.Property(e => e.Configkey)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("configkey");
            entity.Property(e => e.Configvalue).HasColumnName("configvalue");
            entity.Property(e => e.Lazy)
                .HasDefaultValue((short)0)
                .HasColumnName("lazy");
            entity.Property(e => e.Type)
                .HasDefaultValue(2)
                .HasColumnName("type");
        });

        modelBuilder.Entity<OcAuthorizedGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_authorized_groups_pkey");

            entity.ToTable("oc_authorized_groups");

            entity.HasIndex(e => e.GroupId, "admindel_groupid_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Class)
                .HasMaxLength(200)
                .HasColumnName("class");
            entity.Property(e => e.GroupId)
                .HasMaxLength(200)
                .HasColumnName("group_id");
        });

        modelBuilder.Entity<OcAuthtoken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_authtoken_pkey");

            entity.ToTable("oc_authtoken");

            entity.HasIndex(e => e.LastActivity, "authtoken_last_activity_idx");

            entity.HasIndex(e => e.Token, "authtoken_token_index").IsUnique();

            entity.HasIndex(e => e.Uid, "authtoken_uid_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.LastActivity)
                .HasDefaultValue(0)
                .HasColumnName("last_activity");
            entity.Property(e => e.LastCheck)
                .HasDefaultValue(0)
                .HasColumnName("last_check");
            entity.Property(e => e.LoginName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("login_name");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''::text")
                .HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("password_hash");
            entity.Property(e => e.PasswordInvalid)
                .HasDefaultValue(false)
                .HasColumnName("password_invalid");
            entity.Property(e => e.PrivateKey).HasColumnName("private_key");
            entity.Property(e => e.PublicKey).HasColumnName("public_key");
            entity.Property(e => e.Remember)
                .HasDefaultValue((short)0)
                .HasColumnName("remember");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Token)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("token");
            entity.Property(e => e.Type)
                .HasDefaultValue((short)0)
                .HasColumnName("type");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid");
            entity.Property(e => e.Version)
                .HasDefaultValue((short)1)
                .HasColumnName("version");
        });

        modelBuilder.Entity<OcBruteforceAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_bruteforce_attempts_pkey");

            entity.ToTable("oc_bruteforce_attempts");

            entity.HasIndex(e => e.Ip, "bruteforce_attempts_ip");

            entity.HasIndex(e => e.Subnet, "bruteforce_attempts_subnet");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("action");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ip");
            entity.Property(e => e.Metadata)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("metadata");
            entity.Property(e => e.Occurred)
                .HasDefaultValue(0)
                .HasColumnName("occurred");
            entity.Property(e => e.Subnet)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("subnet");
        });

        modelBuilder.Entity<OcCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendars_pkey");

            entity.ToTable("oc_calendars");

            entity.HasIndex(e => new { e.Principaluri, e.Uri }, "calendars_index").IsUnique();

            entity.HasIndex(e => new { e.Principaluri, e.DeletedAt }, "cals_princ_del_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendarcolor)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("calendarcolor");
            entity.Property(e => e.Calendarorder)
                .HasDefaultValue(0)
                .HasColumnName("calendarorder");
            entity.Property(e => e.Components)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("components");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("description");
            entity.Property(e => e.Displayname)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("displayname");
            entity.Property(e => e.Principaluri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("principaluri");
            entity.Property(e => e.Synctoken)
                .HasDefaultValue(1)
                .HasColumnName("synctoken");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
            entity.Property(e => e.Transparent)
                .HasDefaultValue((short)0)
                .HasColumnName("transparent");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcCalendarInvitation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendar_invitations_pkey");

            entity.ToTable("oc_calendar_invitations");

            entity.HasIndex(e => e.Token, "calendar_invitation_tokens");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attendee)
                .HasMaxLength(255)
                .HasColumnName("attendee");
            entity.Property(e => e.Expiration).HasColumnName("expiration");
            entity.Property(e => e.Organizer)
                .HasMaxLength(255)
                .HasColumnName("organizer");
            entity.Property(e => e.Recurrenceid)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("recurrenceid");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Token)
                .HasMaxLength(60)
                .HasColumnName("token");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcCalendarReminder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendar_reminders_pkey");

            entity.ToTable("oc_calendar_reminders");

            entity.HasIndex(e => e.ObjectId, "calendar_reminder_objid");

            entity.HasIndex(e => new { e.Uid, e.RecurrenceId }, "calendar_reminder_uidrec");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlarmHash)
                .HasMaxLength(255)
                .HasColumnName("alarm_hash");
            entity.Property(e => e.CalendarId).HasColumnName("calendar_id");
            entity.Property(e => e.EventHash)
                .HasMaxLength(255)
                .HasColumnName("event_hash");
            entity.Property(e => e.IsRecurrenceException).HasColumnName("is_recurrence_exception");
            entity.Property(e => e.IsRecurring).HasColumnName("is_recurring");
            entity.Property(e => e.IsRelative).HasColumnName("is_relative");
            entity.Property(e => e.IsRepeatBased).HasColumnName("is_repeat_based");
            entity.Property(e => e.NotificationDate).HasColumnName("notification_date");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.RecurrenceId).HasColumnName("recurrence_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcCalendarResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendar_resources_pkey");

            entity.ToTable("oc_calendar_resources");

            entity.HasIndex(e => new { e.BackendId, e.ResourceId }, "calendar_resources_bkdrsc");

            entity.HasIndex(e => e.Email, "calendar_resources_email");

            entity.HasIndex(e => e.Displayname, "calendar_resources_name");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BackendId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("backend_id");
            entity.Property(e => e.Displayname)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("displayname");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("email");
            entity.Property(e => e.GroupRestrictions)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("group_restrictions");
            entity.Property(e => e.ResourceId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("resource_id");
        });

        modelBuilder.Entity<OcCalendarResourcesMd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendar_resources_md_pkey");

            entity.ToTable("oc_calendar_resources_md");

            entity.HasIndex(e => new { e.ResourceId, e.Key }, "calendar_resources_md_idk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.Value)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcCalendarRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendar_rooms_pkey");

            entity.ToTable("oc_calendar_rooms");

            entity.HasIndex(e => new { e.BackendId, e.ResourceId }, "calendar_rooms_bkdrsc");

            entity.HasIndex(e => e.Email, "calendar_rooms_email");

            entity.HasIndex(e => e.Displayname, "calendar_rooms_name");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BackendId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("backend_id");
            entity.Property(e => e.Displayname)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("displayname");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("email");
            entity.Property(e => e.GroupRestrictions)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("group_restrictions");
            entity.Property(e => e.ResourceId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("resource_id");
        });

        modelBuilder.Entity<OcCalendarRoomsMd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendar_rooms_md_pkey");

            entity.ToTable("oc_calendar_rooms_md");

            entity.HasIndex(e => new { e.RoomId, e.Key }, "calendar_rooms_md_idk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.Value)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcCalendarchange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendarchanges_pkey");

            entity.ToTable("oc_calendarchanges");

            entity.HasIndex(e => new { e.Calendarid, e.Calendartype, e.Synctoken }, "calid_type_synctoken");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendarid).HasColumnName("calendarid");
            entity.Property(e => e.Calendartype)
                .HasDefaultValue(0)
                .HasColumnName("calendartype");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValue(0)
                .HasColumnName("created_at");
            entity.Property(e => e.Operation).HasColumnName("operation");
            entity.Property(e => e.Synctoken)
                .HasDefaultValue(1)
                .HasColumnName("synctoken");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcCalendarobject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendarobjects_pkey");

            entity.ToTable("oc_calendarobjects");

            entity.HasIndex(e => e.Classification, "calobj_clssfction_index");

            entity.HasIndex(e => new { e.Calendarid, e.Calendartype, e.Uri }, "calobjects_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendardata).HasColumnName("calendardata");
            entity.Property(e => e.Calendarid).HasColumnName("calendarid");
            entity.Property(e => e.Calendartype)
                .HasDefaultValue(0)
                .HasColumnName("calendartype");
            entity.Property(e => e.Classification)
                .HasDefaultValue(0)
                .HasColumnName("classification");
            entity.Property(e => e.Componenttype)
                .HasMaxLength(8)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("componenttype");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Etag)
                .HasMaxLength(32)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("etag");
            entity.Property(e => e.Firstoccurence).HasColumnName("firstoccurence");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Lastoccurence).HasColumnName("lastoccurence");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uid");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcCalendarobjectsProp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendarobjects_props_pkey");

            entity.ToTable("oc_calendarobjects_props");

            entity.HasIndex(e => new { e.Calendarid, e.Calendartype }, "calendarobject_calid_index");

            entity.HasIndex(e => new { e.Objectid, e.Calendartype }, "calendarobject_index");

            entity.HasIndex(e => new { e.Name, e.Calendartype }, "calendarobject_name_index");

            entity.HasIndex(e => new { e.Value, e.Calendartype }, "calendarobject_value_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendarid)
                .HasDefaultValue(0L)
                .HasColumnName("calendarid");
            entity.Property(e => e.Calendartype)
                .HasDefaultValue(0)
                .HasColumnName("calendartype");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Objectid)
                .HasDefaultValue(0L)
                .HasColumnName("objectid");
            entity.Property(e => e.Parameter)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("parameter");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcCalendarsubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_calendarsubscriptions_pkey");

            entity.ToTable("oc_calendarsubscriptions");

            entity.HasIndex(e => new { e.Principaluri, e.Uri }, "calsub_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendarcolor)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("calendarcolor");
            entity.Property(e => e.Calendarorder)
                .HasDefaultValue(0)
                .HasColumnName("calendarorder");
            entity.Property(e => e.Displayname)
                .HasMaxLength(100)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("displayname");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Principaluri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("principaluri");
            entity.Property(e => e.Refreshrate)
                .HasMaxLength(10)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("refreshrate");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.Stripalarms).HasColumnName("stripalarms");
            entity.Property(e => e.Stripattachments).HasColumnName("stripattachments");
            entity.Property(e => e.Striptodos).HasColumnName("striptodos");
            entity.Property(e => e.Synctoken)
                .HasDefaultValue(1)
                .HasColumnName("synctoken");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_cards_pkey");

            entity.ToTable("oc_cards");

            entity.HasIndex(e => new { e.Addressbookid, e.Uri }, "cards_abiduri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addressbookid)
                .HasDefaultValue(0L)
                .HasColumnName("addressbookid");
            entity.Property(e => e.Carddata).HasColumnName("carddata");
            entity.Property(e => e.Etag)
                .HasMaxLength(32)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("etag");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uid");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcCardsProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_cards_properties_pkey");

            entity.ToTable("oc_cards_properties");

            entity.HasIndex(e => e.Cardid, "card_contactid_index");

            entity.HasIndex(e => e.Name, "card_name_index");

            entity.HasIndex(e => e.Value, "card_value_index");

            entity.HasIndex(e => e.Addressbookid, "cards_prop_abid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addressbookid)
                .HasDefaultValue(0L)
                .HasColumnName("addressbookid");
            entity.Property(e => e.Cardid)
                .HasDefaultValue(0L)
                .HasColumnName("cardid");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Preferred)
                .HasDefaultValue(1)
                .HasColumnName("preferred");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcCirclesCircle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_circles_circle_pkey");

            entity.ToTable("oc_circles_circle");

            entity.HasIndex(e => e.DisplayName, "dname");

            entity.HasIndex(e => e.Instance, "idx_8195f5484230b1de");

            entity.HasIndex(e => e.Source, "idx_8195f5485f8a7f73");

            entity.HasIndex(e => e.SanitizedName, "idx_8195f548c317b362");

            entity.HasIndex(e => e.Config, "idx_8195f548d48a2f7c");

            entity.HasIndex(e => e.UniqueId, "uniq_8195f548e3c68343").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Config).HasColumnName("config");
            entity.Property(e => e.ContactAddressbook).HasColumnName("contact_addressbook");
            entity.Property(e => e.ContactGroupname)
                .HasMaxLength(127)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("contact_groupname");
            entity.Property(e => e.Creation)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("creation");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("display_name");
            entity.Property(e => e.Instance)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("instance");
            entity.Property(e => e.Name)
                .HasMaxLength(127)
                .HasColumnName("name");
            entity.Property(e => e.SanitizedName)
                .HasMaxLength(127)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sanitized_name");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(31)
                .HasColumnName("unique_id");
        });

        modelBuilder.Entity<OcCirclesEvent>(entity =>
        {
            entity.HasKey(e => new { e.Token, e.Instance }).HasName("oc_circles_event_pkey");

            entity.ToTable("oc_circles_event");

            entity.Property(e => e.Token)
                .HasMaxLength(63)
                .HasColumnName("token");
            entity.Property(e => e.Instance)
                .HasMaxLength(255)
                .HasColumnName("instance");
            entity.Property(e => e.Creation).HasColumnName("creation");
            entity.Property(e => e.Event).HasColumnName("event");
            entity.Property(e => e.Interface)
                .HasDefaultValue(0)
                .HasColumnName("interface");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.Retry).HasColumnName("retry");
            entity.Property(e => e.Severity).HasColumnName("severity");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Updated)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<OcCirclesMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_circles_member_pkey");

            entity.ToTable("oc_circles_member");

            entity.HasIndex(e => new { e.CircleId, e.SingleId }, "circles_member_cisi");

            entity.HasIndex(e => new { e.CircleId, e.SingleId, e.UserId, e.UserType, e.Instance, e.Level }, "circles_member_cisiuiutil");

            entity.HasIndex(e => e.ContactId, "idx_25c66a49e7a1254a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CachedName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cached_name");
            entity.Property(e => e.CachedUpdate)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("cached_update");
            entity.Property(e => e.CircleId)
                .HasMaxLength(31)
                .HasColumnName("circle_id");
            entity.Property(e => e.ContactId)
                .HasMaxLength(127)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("contact_id");
            entity.Property(e => e.ContactMeta).HasColumnName("contact_meta");
            entity.Property(e => e.Instance)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("instance");
            entity.Property(e => e.InvitedBy)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("invited_by");
            entity.Property(e => e.Joined)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("joined");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MemberId)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("member_id");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.SingleId)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("single_id");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasMaxLength(127)
                .HasColumnName("user_id");
            entity.Property(e => e.UserType)
                .HasDefaultValue((short)1)
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<OcCirclesMembership>(entity =>
        {
            entity.HasKey(e => new { e.SingleId, e.CircleId }).HasName("oc_circles_membership_pkey");

            entity.ToTable("oc_circles_membership");

            entity.HasIndex(e => new { e.InheritanceFirst, e.InheritanceLast, e.CircleId }, "circles_membership_ifilci");

            entity.HasIndex(e => e.SingleId, "idx_8fc816eae7c1d92b");

            entity.Property(e => e.SingleId)
                .HasMaxLength(31)
                .HasColumnName("single_id");
            entity.Property(e => e.CircleId)
                .HasMaxLength(31)
                .HasColumnName("circle_id");
            entity.Property(e => e.InheritanceDepth).HasColumnName("inheritance_depth");
            entity.Property(e => e.InheritanceFirst)
                .HasMaxLength(31)
                .HasColumnName("inheritance_first");
            entity.Property(e => e.InheritanceLast)
                .HasMaxLength(31)
                .HasColumnName("inheritance_last");
            entity.Property(e => e.InheritancePath).HasColumnName("inheritance_path");
            entity.Property(e => e.Level).HasColumnName("level");
        });

        modelBuilder.Entity<OcCirclesMount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_circles_mount_pkey");

            entity.ToTable("oc_circles_mount");

            entity.HasIndex(e => new { e.CircleId, e.MountId, e.Parent, e.Token }, "circles_mount_cimipt");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CircleId)
                .HasMaxLength(31)
                .HasColumnName("circle_id");
            entity.Property(e => e.MountId)
                .HasMaxLength(31)
                .HasColumnName("mount_id");
            entity.Property(e => e.Mountpoint).HasColumnName("mountpoint");
            entity.Property(e => e.MountpointHash)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("mountpoint_hash");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.SingleId)
                .HasMaxLength(31)
                .HasColumnName("single_id");
            entity.Property(e => e.Token)
                .HasMaxLength(63)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("token");
        });

        modelBuilder.Entity<OcCirclesMountpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_circles_mountpoint_pkey");

            entity.ToTable("oc_circles_mountpoint");

            entity.HasIndex(e => new { e.MountId, e.SingleId }, "circles_mountpoint_ms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MountId)
                .HasMaxLength(31)
                .HasColumnName("mount_id");
            entity.Property(e => e.Mountpoint).HasColumnName("mountpoint");
            entity.Property(e => e.MountpointHash)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("mountpoint_hash");
            entity.Property(e => e.SingleId)
                .HasMaxLength(31)
                .HasColumnName("single_id");
        });

        modelBuilder.Entity<OcCirclesRemote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_circles_remote_pkey");

            entity.ToTable("oc_circles_remote");

            entity.HasIndex(e => e.Href, "idx_f94ef8334f8e741");

            entity.HasIndex(e => e.Uid, "idx_f94ef83539b0606");

            entity.HasIndex(e => e.Instance, "uniq_f94ef834230b1de").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creation)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("creation");
            entity.Property(e => e.Href)
                .HasMaxLength(254)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("href");
            entity.Property(e => e.Instance)
                .HasMaxLength(127)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("instance");
            entity.Property(e => e.Interface)
                .HasDefaultValue(0)
                .HasColumnName("interface");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .HasDefaultValueSql("'Unknown'::character varying")
                .HasColumnName("type");
            entity.Property(e => e.Uid)
                .HasMaxLength(20)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcCirclesShareLock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_circles_share_lock_pkey");

            entity.ToTable("oc_circles_share_lock");

            entity.HasIndex(e => new { e.ItemId, e.CircleId }, "uniq_337f52f8126f525e70ee2ff6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CircleId)
                .HasMaxLength(31)
                .HasColumnName("circle_id");
            entity.Property(e => e.Instance)
                .HasMaxLength(127)
                .HasColumnName("instance");
            entity.Property(e => e.ItemId)
                .HasMaxLength(31)
                .HasColumnName("item_id");
        });

        modelBuilder.Entity<OcCirclesToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_circles_token_pkey");

            entity.ToTable("oc_circles_token");

            entity.HasIndex(e => new { e.ShareId, e.CircleId, e.SingleId, e.MemberId, e.Token }, "sicisimit").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accepted).HasColumnName("accepted");
            entity.Property(e => e.CircleId)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("circle_id");
            entity.Property(e => e.MemberId)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("member_id");
            entity.Property(e => e.Password)
                .HasMaxLength(127)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("password");
            entity.Property(e => e.ShareId).HasColumnName("share_id");
            entity.Property(e => e.SingleId)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("single_id");
            entity.Property(e => e.Token)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("token");
        });

        modelBuilder.Entity<OcCollresAccesscache>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CollectionId, e.ResourceType, e.ResourceId }).HasName("oc_collres_accesscache_pkey");

            entity.ToTable("oc_collres_accesscache");

            entity.HasIndex(e => new { e.UserId, e.ResourceType, e.ResourceId }, "collres_user_res");

            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id");
            entity.Property(e => e.CollectionId)
                .HasDefaultValue(0L)
                .HasColumnName("collection_id");
            entity.Property(e => e.ResourceType)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("resource_type");
            entity.Property(e => e.ResourceId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("resource_id");
            entity.Property(e => e.Access)
                .HasDefaultValue(false)
                .HasColumnName("access");
        });

        modelBuilder.Entity<OcCollresCollection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_collres_collections_pkey");

            entity.ToTable("oc_collres_collections");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcCollresResource>(entity =>
        {
            entity.HasKey(e => new { e.CollectionId, e.ResourceType, e.ResourceId }).HasName("oc_collres_resources_pkey");

            entity.ToTable("oc_collres_resources");

            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.ResourceType)
                .HasMaxLength(64)
                .HasColumnName("resource_type");
            entity.Property(e => e.ResourceId)
                .HasMaxLength(64)
                .HasColumnName("resource_id");
        });

        modelBuilder.Entity<OcComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_comments_pkey");

            entity.ToTable("oc_comments");

            entity.HasIndex(e => new { e.ActorType, e.ActorId }, "comments_actor_index");

            entity.HasIndex(e => new { e.ObjectType, e.ObjectId, e.CreationTimestamp }, "comments_object_index");

            entity.HasIndex(e => e.ParentId, "comments_parent_id_index");

            entity.HasIndex(e => e.TopmostParentId, "comments_topmost_parent_id_idx");

            entity.HasIndex(e => e.ExpireDate, "expire_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActorId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("actor_id");
            entity.Property(e => e.ActorType)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("actor_type");
            entity.Property(e => e.ChildrenCount)
                .HasDefaultValue(0)
                .HasColumnName("children_count");
            entity.Property(e => e.CreationTimestamp)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("creation_timestamp");
            entity.Property(e => e.ExpireDate)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("expire_date");
            entity.Property(e => e.LatestChildTimestamp)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("latest_child_timestamp");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.MetaData)
                .HasDefaultValueSql("''::text")
                .HasColumnName("meta_data");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("object_type");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0L)
                .HasColumnName("parent_id");
            entity.Property(e => e.Reactions)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("reactions");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("reference_id");
            entity.Property(e => e.TopmostParentId)
                .HasDefaultValue(0L)
                .HasColumnName("topmost_parent_id");
            entity.Property(e => e.Verb)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("verb");
        });

        modelBuilder.Entity<OcCommentsReadMarker>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ObjectType, e.ObjectId }).HasName("oc_comments_read_markers_pkey");

            entity.ToTable("oc_comments_read_markers");

            entity.HasIndex(e => new { e.ObjectType, e.ObjectId }, "comments_marker_object_index");

            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_id");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("object_type");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("object_id");
            entity.Property(e => e.MarkerDatetime)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("marker_datetime");
        });

        modelBuilder.Entity<OcDavAbsence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_dav_absence_pkey");

            entity.ToTable("oc_dav_absence");

            entity.HasIndex(e => e.UserId, "dav_absence_uid_idx").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstDay)
                .HasMaxLength(10)
                .HasColumnName("first_day");
            entity.Property(e => e.LastDay)
                .HasMaxLength(10)
                .HasColumnName("last_day");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcDavCalProxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_dav_cal_proxy_pkey");

            entity.ToTable("oc_dav_cal_proxy");

            entity.HasIndex(e => e.ProxyId, "dav_cal_proxy_ipid");

            entity.HasIndex(e => new { e.OwnerId, e.ProxyId, e.Permissions }, "dav_cal_proxy_uidx").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(64)
                .HasColumnName("owner_id");
            entity.Property(e => e.Permissions).HasColumnName("permissions");
            entity.Property(e => e.ProxyId)
                .HasMaxLength(64)
                .HasColumnName("proxy_id");
        });

        modelBuilder.Entity<OcDavShare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_dav_shares_pkey");

            entity.ToTable("oc_dav_shares");

            entity.HasIndex(e => new { e.Principaluri, e.Resourceid, e.Type, e.Publicuri }, "dav_shares_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access).HasColumnName("access");
            entity.Property(e => e.Principaluri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("principaluri");
            entity.Property(e => e.Publicuri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("publicuri");
            entity.Property(e => e.Resourceid).HasColumnName("resourceid");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("type");
        });

        modelBuilder.Entity<OcDirectEdit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_direct_edit_pkey");

            entity.ToTable("oc_direct_edit");

            entity.HasIndex(e => e.Timestamp, "direct_edit_timestamp");

            entity.HasIndex(e => e.Token, "idx_4d5afeca5f37a13b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accessed)
                .HasDefaultValue(false)
                .HasColumnName("accessed");
            entity.Property(e => e.EditorId)
                .HasMaxLength(64)
                .HasColumnName("editor_id");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.FilePath)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("file_path");
            entity.Property(e => e.ShareId).HasColumnName("share_id");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .HasColumnName("token");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcDirectlink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_directlink_pkey");

            entity.ToTable("oc_directlink");

            entity.HasIndex(e => e.Expiration, "directlink_expiration_idx");

            entity.HasIndex(e => e.Token, "directlink_token_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expiration).HasColumnName("expiration");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.Token)
                .HasMaxLength(60)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("token");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcFederatedReshare>(entity =>
        {
            entity.HasKey(e => e.ShareId).HasName("oc_federated_reshares_pkey");

            entity.ToTable("oc_federated_reshares");

            entity.Property(e => e.ShareId)
                .ValueGeneratedNever()
                .HasColumnName("share_id");
            entity.Property(e => e.RemoteId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("remote_id");
        });

        modelBuilder.Entity<OcFileLock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_file_locks_pkey");

            entity.ToTable("oc_file_locks");

            entity.HasIndex(e => e.Key, "lock_key_index").IsUnique();

            entity.HasIndex(e => e.Ttl, "lock_ttl_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .HasColumnName("key");
            entity.Property(e => e.Lock)
                .HasDefaultValue(0)
                .HasColumnName("lock");
            entity.Property(e => e.Ttl)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("ttl");
        });

        modelBuilder.Entity<OcFilecache>(entity =>
        {
            entity.HasKey(e => e.Fileid).HasName("oc_filecache_pkey");

            entity.ToTable("oc_filecache");

            entity.HasIndex(e => new { e.Fileid, e.Storage, e.Size }, "fs_id_storage_size");

            entity.HasIndex(e => e.Mtime, "fs_mtime");

            entity.HasIndex(e => e.Parent, "fs_parent");

            entity.HasIndex(e => new { e.Parent, e.Name }, "fs_parent_name_hash");

            entity.HasIndex(e => e.Size, "fs_size");

            entity.HasIndex(e => new { e.Storage, e.Mimepart }, "fs_storage_mimepart");

            entity.HasIndex(e => new { e.Storage, e.Mimetype }, "fs_storage_mimetype");

            entity.HasIndex(e => new { e.Storage, e.PathHash }, "fs_storage_path_hash").IsUnique();

            entity.HasIndex(e => new { e.Storage, e.Size, e.Fileid }, "fs_storage_size");

            entity.Property(e => e.Fileid).HasColumnName("fileid");
            entity.Property(e => e.Checksum)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("checksum");
            entity.Property(e => e.Encrypted)
                .HasDefaultValue(0)
                .HasColumnName("encrypted");
            entity.Property(e => e.Etag)
                .HasMaxLength(40)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("etag");
            entity.Property(e => e.Mimepart)
                .HasDefaultValue(0L)
                .HasColumnName("mimepart");
            entity.Property(e => e.Mimetype)
                .HasDefaultValue(0L)
                .HasColumnName("mimetype");
            entity.Property(e => e.Mtime)
                .HasDefaultValue(0L)
                .HasColumnName("mtime");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasDefaultValue(0L)
                .HasColumnName("parent");
            entity.Property(e => e.Path)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("path");
            entity.Property(e => e.PathHash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("path_hash");
            entity.Property(e => e.Permissions)
                .HasDefaultValue(0)
                .HasColumnName("permissions");
            entity.Property(e => e.Size)
                .HasDefaultValue(0L)
                .HasColumnName("size");
            entity.Property(e => e.Storage)
                .HasDefaultValue(0L)
                .HasColumnName("storage");
            entity.Property(e => e.StorageMtime)
                .HasDefaultValue(0L)
                .HasColumnName("storage_mtime");
            entity.Property(e => e.UnencryptedSize)
                .HasDefaultValue(0L)
                .HasColumnName("unencrypted_size");
        });

        modelBuilder.Entity<OcFilecacheExtended>(entity =>
        {
            entity.HasKey(e => e.Fileid).HasName("oc_filecache_extended_pkey");

            entity.ToTable("oc_filecache_extended");

            entity.HasIndex(e => e.CreationTime, "fce_ctime_idx");

            entity.HasIndex(e => e.UploadTime, "fce_utime_idx");

            entity.Property(e => e.Fileid)
                .ValueGeneratedNever()
                .HasColumnName("fileid");
            entity.Property(e => e.CreationTime)
                .HasDefaultValue(0L)
                .HasColumnName("creation_time");
            entity.Property(e => e.MetadataEtag)
                .HasMaxLength(40)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("metadata_etag");
            entity.Property(e => e.UploadTime)
                .HasDefaultValue(0L)
                .HasColumnName("upload_time");
        });

        modelBuilder.Entity<OcFilesMetadataIndex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_files_metadata_index_pkey");

            entity.ToTable("oc_files_metadata_index");

            entity.HasIndex(e => new { e.FileId, e.MetaKey, e.MetaValueString }, "f_meta_index");

            entity.HasIndex(e => new { e.FileId, e.MetaKey, e.MetaValueInt }, "f_meta_index_i");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(31)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValueInt).HasColumnName("meta_value_int");
            entity.Property(e => e.MetaValueString)
                .HasMaxLength(63)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("meta_value_string");
        });

        modelBuilder.Entity<OcFilesMetadatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_files_metadata_pkey");

            entity.ToTable("oc_files_metadata");

            entity.HasIndex(e => e.FileId, "files_meta_fileid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.Json).HasColumnName("json");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("last_update");
            entity.Property(e => e.SyncToken)
                .HasMaxLength(15)
                .HasColumnName("sync_token");
        });

        modelBuilder.Entity<OcFilesReminder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_files_reminders_pkey");

            entity.ToTable("oc_files_reminders");

            entity.HasIndex(e => new { e.UserId, e.FileId, e.DueDate }, "reminders_uniq_idx").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DueDate)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("due_date");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.Notified)
                .HasDefaultValue(false)
                .HasColumnName("notified");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcFilesTrash>(entity =>
        {
            entity.HasKey(e => e.AutoId).HasName("oc_files_trash_pkey");

            entity.ToTable("oc_files_trash");

            entity.HasIndex(e => e.Id, "id_index");

            entity.HasIndex(e => e.Timestamp, "timestamp_index");

            entity.HasIndex(e => e.User, "user_index");

            entity.Property(e => e.AutoId).HasColumnName("auto_id");
            entity.Property(e => e.Id)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id");
            entity.Property(e => e.Location)
                .HasMaxLength(512)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("location");
            entity.Property(e => e.Mime)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("mime");
            entity.Property(e => e.Timestamp)
                .HasMaxLength(12)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasMaxLength(4)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("type");
            entity.Property(e => e.User)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user");
        });

        modelBuilder.Entity<OcFilesVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_files_versions_pkey");

            entity.ToTable("oc_files_versions");

            entity.HasIndex(e => new { e.FileId, e.Timestamp }, "files_versions_uniq_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.Metadata)
                .HasColumnType("json")
                .HasColumnName("metadata");
            entity.Property(e => e.Mimetype).HasColumnName("mimetype");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
        });

        modelBuilder.Entity<OcFlowCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_flow_checks_pkey");

            entity.ToTable("oc_flow_checks");

            entity.HasIndex(e => e.Hash, "flow_unique_hash").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Class)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("class");
            entity.Property(e => e.Hash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hash");
            entity.Property(e => e.Operator)
                .HasMaxLength(16)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("operator");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<OcFlowOperation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_flow_operations_pkey");

            entity.ToTable("oc_flow_operations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checks).HasColumnName("checks");
            entity.Property(e => e.Class)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("class");
            entity.Property(e => e.Entity)
                .HasMaxLength(256)
                .HasDefaultValueSql("'OCA\\WorkflowEngine\\Entity\\File'::character varying")
                .HasColumnName("entity");
            entity.Property(e => e.Events)
                .HasDefaultValueSql("'[]'::text")
                .HasColumnName("events");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Operation).HasColumnName("operation");
        });

        modelBuilder.Entity<OcFlowOperationsScope>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_flow_operations_scope_pkey");

            entity.ToTable("oc_flow_operations_scope");

            entity.HasIndex(e => new { e.OperationId, e.Type, e.Value }, "flow_unique_scope").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OperationId)
                .HasDefaultValue(0)
                .HasColumnName("operation_id");
            entity.Property(e => e.Type)
                .HasDefaultValue(0)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcGroup>(entity =>
        {
            entity.HasKey(e => e.Gid).HasName("oc_groups_pkey");

            entity.ToTable("oc_groups");

            entity.Property(e => e.Gid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("gid");
            entity.Property(e => e.Displayname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'name'::character varying")
                .HasColumnName("displayname");
        });

        modelBuilder.Entity<OcGroupAdmin>(entity =>
        {
            entity.HasKey(e => new { e.Gid, e.Uid }).HasName("oc_group_admin_pkey");

            entity.ToTable("oc_group_admin");

            entity.HasIndex(e => e.Uid, "group_admin_uid");

            entity.Property(e => e.Gid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("gid");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcGroupUser>(entity =>
        {
            entity.HasKey(e => new { e.Gid, e.Uid }).HasName("oc_group_user_pkey");

            entity.ToTable("oc_group_user");

            entity.HasIndex(e => e.Uid, "gu_uid_index");

            entity.Property(e => e.Gid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("gid");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_jobs_pkey");

            entity.ToTable("oc_jobs");

            entity.HasIndex(e => new { e.Class, e.ArgumentHash }, "job_argument_hash");

            entity.HasIndex(e => e.Class, "job_class_index");

            entity.HasIndex(e => new { e.LastChecked, e.ReservedAt }, "job_lastcheck_reserved");

            entity.HasIndex(e => e.TimeSensitive, "jobs_time_sensitive");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Argument)
                .HasMaxLength(4000)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("argument");
            entity.Property(e => e.ArgumentHash)
                .HasMaxLength(32)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("argument_hash");
            entity.Property(e => e.Class)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("class");
            entity.Property(e => e.ExecutionDuration)
                .HasDefaultValue(0)
                .HasColumnName("execution_duration");
            entity.Property(e => e.LastChecked)
                .HasDefaultValue(0)
                .HasColumnName("last_checked");
            entity.Property(e => e.LastRun)
                .HasDefaultValue(0)
                .HasColumnName("last_run");
            entity.Property(e => e.ReservedAt)
                .HasDefaultValue(0)
                .HasColumnName("reserved_at");
            entity.Property(e => e.TimeSensitive)
                .HasDefaultValue((short)1)
                .HasColumnName("time_sensitive");
        });

        modelBuilder.Entity<OcKnownUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_known_users_pkey");

            entity.ToTable("oc_known_users");

            entity.HasIndex(e => e.KnownTo, "ku_known_to");

            entity.HasIndex(e => e.KnownUser, "ku_known_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KnownTo)
                .HasMaxLength(255)
                .HasColumnName("known_to");
            entity.Property(e => e.KnownUser)
                .HasMaxLength(255)
                .HasColumnName("known_user");
        });

        modelBuilder.Entity<OcLoginFlowV2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_login_flow_v2_pkey");

            entity.ToTable("oc_login_flow_v2");

            entity.HasIndex(e => e.LoginToken, "login_token").IsUnique();

            entity.HasIndex(e => e.PollToken, "poll_token").IsUnique();

            entity.HasIndex(e => e.Timestamp, "timestamp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppPassword)
                .HasMaxLength(1024)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("app_password");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("client_name");
            entity.Property(e => e.LoginName)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("login_name");
            entity.Property(e => e.LoginToken)
                .HasMaxLength(255)
                .HasColumnName("login_token");
            entity.Property(e => e.PollToken)
                .HasMaxLength(255)
                .HasColumnName("poll_token");
            entity.Property(e => e.PrivateKey).HasColumnName("private_key");
            entity.Property(e => e.PublicKey).HasColumnName("public_key");
            entity.Property(e => e.Server)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("server");
            entity.Property(e => e.Started)
                .HasDefaultValue((short)0)
                .HasColumnName("started");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
        });

        modelBuilder.Entity<OcMigration>(entity =>
        {
            entity.HasKey(e => new { e.App, e.Version }).HasName("oc_migrations_pkey");

            entity.ToTable("oc_migrations");

            entity.Property(e => e.App)
                .HasMaxLength(255)
                .HasColumnName("app");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version");
        });

        modelBuilder.Entity<OcMimetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_mimetypes_pkey");

            entity.ToTable("oc_mimetypes");

            entity.HasIndex(e => e.Mimetype, "mimetype_id_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mimetype");
        });

        modelBuilder.Entity<OcMount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_mounts_pkey");

            entity.ToTable("oc_mounts");

            entity.HasIndex(e => new { e.StorageId, e.UserId }, "mount_user_storage");

            entity.HasIndex(e => e.MountProviderClass, "mounts_class_index");

            entity.HasIndex(e => e.MountId, "mounts_mount_id_index");

            entity.HasIndex(e => e.RootId, "mounts_root_index");

            entity.HasIndex(e => e.StorageId, "mounts_storage_index");

            entity.HasIndex(e => new { e.UserId, e.RootId, e.MountPoint }, "mounts_user_root_path_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MountId).HasColumnName("mount_id");
            entity.Property(e => e.MountPoint)
                .HasMaxLength(4000)
                .HasColumnName("mount_point");
            entity.Property(e => e.MountProviderClass)
                .HasMaxLength(128)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("mount_provider_class");
            entity.Property(e => e.RootId).HasColumnName("root_id");
            entity.Property(e => e.StorageId).HasColumnName("storage_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcNotification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("oc_notifications_pkey");

            entity.ToTable("oc_notifications");

            entity.HasIndex(e => e.App, "oc_notifications_app");

            entity.HasIndex(e => new { e.ObjectType, e.ObjectId }, "oc_notifications_object");

            entity.HasIndex(e => e.Timestamp, "oc_notifications_timestamp");

            entity.HasIndex(e => e.User, "oc_notifications_user");

            entity.Property(e => e.NotificationId).HasColumnName("notification_id");
            entity.Property(e => e.Actions).HasColumnName("actions");
            entity.Property(e => e.App)
                .HasMaxLength(32)
                .HasColumnName("app");
            entity.Property(e => e.Icon)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("icon");
            entity.Property(e => e.Link)
                .HasMaxLength(4000)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("link");
            entity.Property(e => e.Message)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("message");
            entity.Property(e => e.MessageParameters).HasColumnName("message_parameters");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(64)
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(64)
                .HasColumnName("object_type");
            entity.Property(e => e.Subject)
                .HasMaxLength(64)
                .HasColumnName("subject");
            entity.Property(e => e.SubjectParameters).HasColumnName("subject_parameters");
            entity.Property(e => e.Timestamp)
                .HasDefaultValue(0)
                .HasColumnName("timestamp");
            entity.Property(e => e.User)
                .HasMaxLength(64)
                .HasColumnName("user");
        });

        modelBuilder.Entity<OcNotificationsPushhash>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_notifications_pushhash_pkey");

            entity.ToTable("oc_notifications_pushhash");

            entity.HasIndex(e => new { e.Uid, e.Token }, "oc_npushhash_uid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apptype)
                .HasMaxLength(32)
                .HasDefaultValueSql("'unknown'::character varying")
                .HasColumnName("apptype");
            entity.Property(e => e.Deviceidentifier)
                .HasMaxLength(128)
                .HasColumnName("deviceidentifier");
            entity.Property(e => e.Devicepublickey)
                .HasMaxLength(512)
                .HasColumnName("devicepublickey");
            entity.Property(e => e.Devicepublickeyhash)
                .HasMaxLength(128)
                .HasColumnName("devicepublickeyhash");
            entity.Property(e => e.Proxyserver)
                .HasMaxLength(256)
                .HasColumnName("proxyserver");
            entity.Property(e => e.Pushtokenhash)
                .HasMaxLength(128)
                .HasColumnName("pushtokenhash");
            entity.Property(e => e.Token)
                .HasDefaultValue(0)
                .HasColumnName("token");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcNotificationsSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_notifications_settings_pkey");

            entity.ToTable("oc_notifications_settings");

            entity.HasIndex(e => e.NextSendTime, "notset_nextsend");

            entity.HasIndex(e => e.UserId, "notset_user").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchTime)
                .HasDefaultValue(0)
                .HasColumnName("batch_time");
            entity.Property(e => e.LastSendId)
                .HasDefaultValue(0L)
                .HasColumnName("last_send_id");
            entity.Property(e => e.NextSendTime)
                .HasDefaultValue(0)
                .HasColumnName("next_send_time");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcOauth2AccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_oauth2_access_tokens_pkey");

            entity.ToTable("oc_oauth2_access_tokens");

            entity.HasIndex(e => e.ClientId, "oauth2_access_client_id_idx");

            entity.HasIndex(e => e.HashedCode, "oauth2_access_hash_idx").IsUnique();

            entity.HasIndex(e => new { e.TokenCount, e.CodeCreatedAt }, "oauth2_tk_c_created_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CodeCreatedAt)
                .HasDefaultValue(0L)
                .HasColumnName("code_created_at");
            entity.Property(e => e.EncryptedToken)
                .HasMaxLength(786)
                .HasColumnName("encrypted_token");
            entity.Property(e => e.HashedCode)
                .HasMaxLength(128)
                .HasColumnName("hashed_code");
            entity.Property(e => e.TokenCount)
                .HasDefaultValue(0L)
                .HasColumnName("token_count");
            entity.Property(e => e.TokenId).HasColumnName("token_id");
        });

        modelBuilder.Entity<OcOauth2Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_oauth2_clients_pkey");

            entity.ToTable("oc_oauth2_clients");

            entity.HasIndex(e => e.ClientIdentifier, "oauth2_client_id_idx").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientIdentifier)
                .HasMaxLength(64)
                .HasColumnName("client_identifier");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.RedirectUri)
                .HasMaxLength(2000)
                .HasColumnName("redirect_uri");
            entity.Property(e => e.Secret)
                .HasMaxLength(512)
                .HasColumnName("secret");
        });

        modelBuilder.Entity<OcOpenLocalEditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_open_local_editor_pkey");

            entity.ToTable("oc_open_local_editor");

            entity.HasIndex(e => new { e.UserId, e.PathHash, e.Token }, "openlocal_user_path_token").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExpirationTime).HasColumnName("expiration_time");
            entity.Property(e => e.PathHash)
                .HasMaxLength(64)
                .HasColumnName("path_hash");
            entity.Property(e => e.Token)
                .HasMaxLength(128)
                .HasColumnName("token");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcPhotosAlbum>(entity =>
        {
            entity.HasKey(e => e.AlbumId).HasName("oc_photos_albums_pkey");

            entity.ToTable("oc_photos_albums");

            entity.HasIndex(e => e.User, "pa_user");

            entity.Property(e => e.AlbumId).HasColumnName("album_id");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.LastAddedPhoto).HasColumnName("last_added_photo");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.User)
                .HasMaxLength(255)
                .HasColumnName("user");
        });

        modelBuilder.Entity<OcPhotosAlbumsCollab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_photos_albums_collabs_pkey");

            entity.ToTable("oc_photos_albums_collabs");

            entity.HasIndex(e => new { e.AlbumId, e.CollaboratorId, e.CollaboratorType }, "album_collabs_uniq_collab").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlbumId).HasColumnName("album_id");
            entity.Property(e => e.CollaboratorId)
                .HasMaxLength(64)
                .HasColumnName("collaborator_id");
            entity.Property(e => e.CollaboratorType).HasColumnName("collaborator_type");
        });

        modelBuilder.Entity<OcPhotosAlbumsFile>(entity =>
        {
            entity.HasKey(e => e.AlbumFileId).HasName("oc_photos_albums_files_pkey");

            entity.ToTable("oc_photos_albums_files");

            entity.HasIndex(e => new { e.AlbumId, e.FileId }, "paf_album_file").IsUnique();

            entity.HasIndex(e => e.AlbumId, "paf_folder");

            entity.Property(e => e.AlbumFileId).HasColumnName("album_file_id");
            entity.Property(e => e.Added).HasColumnName("added");
            entity.Property(e => e.AlbumId).HasColumnName("album_id");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.Owner)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("owner");
        });

        modelBuilder.Entity<OcPreference>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Appid, e.Configkey }).HasName("oc_preferences_pkey");

            entity.ToTable("oc_preferences");

            entity.HasIndex(e => new { e.Appid, e.Configkey }, "preferences_app_key");

            entity.Property(e => e.Userid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("userid");
            entity.Property(e => e.Appid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("appid");
            entity.Property(e => e.Configkey)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("configkey");
            entity.Property(e => e.Configvalue).HasColumnName("configvalue");
        });

        modelBuilder.Entity<OcPrivacyAdmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_privacy_admins_pkey");

            entity.ToTable("oc_privacy_admins");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Displayname)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("displayname");
        });

        modelBuilder.Entity<OcProfileConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_profile_config_pkey");

            entity.ToTable("oc_profile_config");

            entity.HasIndex(e => e.UserId, "profile_config_user_id_idx").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Config).HasColumnName("config");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_properties_pkey");

            entity.ToTable("oc_properties");

            entity.HasIndex(e => new { e.Userid, e.Propertypath }, "properties_path_index");

            entity.HasIndex(e => e.Propertypath, "properties_pathonly_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Propertyname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("propertyname");
            entity.Property(e => e.Propertypath)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("propertypath");
            entity.Property(e => e.Propertyvalue).HasColumnName("propertyvalue");
            entity.Property(e => e.Userid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("userid");
            entity.Property(e => e.Valuetype)
                .HasDefaultValue((short)1)
                .HasColumnName("valuetype");
        });

        modelBuilder.Entity<OcRatelimitEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_ratelimit_entries_pkey");

            entity.ToTable("oc_ratelimit_entries");

            entity.HasIndex(e => e.DeleteAfter, "ratelimit_delete_after");

            entity.HasIndex(e => e.Hash, "ratelimit_hash");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeleteAfter)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("delete_after");
            entity.Property(e => e.Hash)
                .HasMaxLength(128)
                .HasColumnName("hash");
        });

        modelBuilder.Entity<OcReaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_reactions_pkey");

            entity.ToTable("oc_reactions");

            entity.HasIndex(e => e.Reaction, "comment_reaction");

            entity.HasIndex(e => e.ParentId, "comment_reaction_parent_id");

            entity.HasIndex(e => new { e.ParentId, e.ActorType, e.ActorId, e.Reaction }, "comment_reaction_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActorId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("actor_id");
            entity.Property(e => e.ActorType)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("actor_type");
            entity.Property(e => e.MessageId).HasColumnName("message_id");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Reaction)
                .HasMaxLength(32)
                .HasColumnName("reaction");
        });

        modelBuilder.Entity<OcRecentContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_recent_contact_pkey");

            entity.ToTable("oc_recent_contact");

            entity.HasIndex(e => e.ActorUid, "recent_contact_actor_uid");

            entity.HasIndex(e => e.Email, "recent_contact_email");

            entity.HasIndex(e => e.FederatedCloudId, "recent_contact_fed_id");

            entity.HasIndex(e => new { e.Id, e.ActorUid }, "recent_contact_id_uid");

            entity.HasIndex(e => e.LastContact, "recent_contact_last_contact");

            entity.HasIndex(e => e.Uid, "recent_contact_uid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActorUid)
                .HasMaxLength(64)
                .HasColumnName("actor_uid");
            entity.Property(e => e.Card).HasColumnName("card");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("email");
            entity.Property(e => e.FederatedCloudId)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("federated_cloud_id");
            entity.Property(e => e.LastContact).HasColumnName("last_contact");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcSchedulingobject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_schedulingobjects_pkey");

            entity.ToTable("oc_schedulingobjects");

            entity.HasIndex(e => e.Principaluri, "schedulobj_principuri_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendardata).HasColumnName("calendardata");
            entity.Property(e => e.Etag)
                .HasMaxLength(32)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("etag");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Principaluri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("principaluri");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Uri)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uri");
        });

        modelBuilder.Entity<OcShare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_share_pkey");

            entity.ToTable("oc_share");

            entity.HasIndex(e => e.FileSource, "file_source_index");

            entity.HasIndex(e => e.UidInitiator, "initiator_index");

            entity.HasIndex(e => new { e.ItemType, e.ShareType }, "item_share_type_index");

            entity.HasIndex(e => e.UidOwner, "owner_index");

            entity.HasIndex(e => e.Parent, "parent_index");

            entity.HasIndex(e => e.ShareWith, "share_with_index");

            entity.HasIndex(e => e.Token, "token_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accepted)
                .HasDefaultValue((short)0)
                .HasColumnName("accepted");
            entity.Property(e => e.Attributes)
                .HasColumnType("json")
                .HasColumnName("attributes");
            entity.Property(e => e.Expiration)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("expiration");
            entity.Property(e => e.FileSource).HasColumnName("file_source");
            entity.Property(e => e.FileTarget)
                .HasMaxLength(512)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("file_target");
            entity.Property(e => e.HideDownload)
                .HasDefaultValue((short)0)
                .HasColumnName("hide_download");
            entity.Property(e => e.ItemSource)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("item_source");
            entity.Property(e => e.ItemTarget)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("item_target");
            entity.Property(e => e.ItemType)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("item_type");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("label");
            entity.Property(e => e.MailSend)
                .HasDefaultValue((short)0)
                .HasColumnName("mail_send");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("password");
            entity.Property(e => e.PasswordByTalk)
                .HasDefaultValue(false)
                .HasColumnName("password_by_talk");
            entity.Property(e => e.PasswordExpirationTime)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("password_expiration_time");
            entity.Property(e => e.Permissions)
                .HasDefaultValue((short)0)
                .HasColumnName("permissions");
            entity.Property(e => e.ShareName)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("share_name");
            entity.Property(e => e.ShareType)
                .HasDefaultValue((short)0)
                .HasColumnName("share_type");
            entity.Property(e => e.ShareWith)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("share_with");
            entity.Property(e => e.Stime)
                .HasDefaultValue(0L)
                .HasColumnName("stime");
            entity.Property(e => e.Token)
                .HasMaxLength(32)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("token");
            entity.Property(e => e.UidInitiator)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uid_initiator");
            entity.Property(e => e.UidOwner)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid_owner");
        });

        modelBuilder.Entity<OcShareExternal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_share_external_pkey");

            entity.ToTable("oc_share_external");

            entity.HasIndex(e => new { e.User, e.MountpointHash }, "sh_external_mp").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accepted)
                .HasDefaultValue(0)
                .HasColumnName("accepted");
            entity.Property(e => e.Mountpoint)
                .HasMaxLength(4000)
                .HasColumnName("mountpoint");
            entity.Property(e => e.MountpointHash)
                .HasMaxLength(32)
                .HasColumnName("mountpoint_hash");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Owner)
                .HasMaxLength(64)
                .HasColumnName("owner");
            entity.Property(e => e.Parent)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("parent");
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("password");
            entity.Property(e => e.Remote)
                .HasMaxLength(512)
                .HasColumnName("remote");
            entity.Property(e => e.RemoteId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("remote_id");
            entity.Property(e => e.ShareToken)
                .HasMaxLength(64)
                .HasColumnName("share_token");
            entity.Property(e => e.ShareType).HasColumnName("share_type");
            entity.Property(e => e.User)
                .HasMaxLength(64)
                .HasColumnName("user");
        });

        modelBuilder.Entity<OcSharesLimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_shares_limits_pkey");

            entity.ToTable("oc_shares_limits");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("id");
            entity.Property(e => e.Downloads)
                .HasDefaultValue(0L)
                .HasColumnName("downloads");
            entity.Property(e => e.Limit).HasColumnName("limit");
        });

        modelBuilder.Entity<OcStorage>(entity =>
        {
            entity.HasKey(e => e.NumericId).HasName("oc_storages_pkey");

            entity.ToTable("oc_storages");

            entity.HasIndex(e => e.Id, "storages_id_index").IsUnique();

            entity.Property(e => e.NumericId).HasColumnName("numeric_id");
            entity.Property(e => e.Available)
                .HasDefaultValue(1)
                .HasColumnName("available");
            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("id");
            entity.Property(e => e.LastChecked).HasColumnName("last_checked");
        });

        modelBuilder.Entity<OcStoragesCredential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_storages_credentials_pkey");

            entity.ToTable("oc_storages_credentials");

            entity.HasIndex(e => new { e.User, e.Identifier }, "stocred_ui").IsUnique();

            entity.HasIndex(e => e.User, "stocred_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Credentials).HasColumnName("credentials");
            entity.Property(e => e.Identifier)
                .HasMaxLength(64)
                .HasColumnName("identifier");
            entity.Property(e => e.User)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("user");
        });

        modelBuilder.Entity<OcSystemtag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_systemtag_pkey");

            entity.ToTable("oc_systemtag");

            entity.HasIndex(e => new { e.Name, e.Visibility, e.Editable }, "tag_ident").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Editable)
                .HasDefaultValue((short)1)
                .HasColumnName("editable");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Visibility)
                .HasDefaultValue((short)1)
                .HasColumnName("visibility");
        });

        modelBuilder.Entity<OcSystemtagGroup>(entity =>
        {
            entity.HasKey(e => new { e.Gid, e.Systemtagid }).HasName("oc_systemtag_group_pkey");

            entity.ToTable("oc_systemtag_group");

            entity.Property(e => e.Gid)
                .HasMaxLength(255)
                .HasColumnName("gid");
            entity.Property(e => e.Systemtagid)
                .HasDefaultValue(0L)
                .HasColumnName("systemtagid");
        });

        modelBuilder.Entity<OcSystemtagObjectMapping>(entity =>
        {
            entity.HasKey(e => new { e.Objecttype, e.Objectid, e.Systemtagid }).HasName("oc_systemtag_object_mapping_pkey");

            entity.ToTable("oc_systemtag_object_mapping");

            entity.HasIndex(e => new { e.Systemtagid, e.Objecttype }, "systag_by_tagid");

            entity.Property(e => e.Objecttype)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("objecttype");
            entity.Property(e => e.Objectid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("objectid");
            entity.Property(e => e.Systemtagid)
                .HasDefaultValue(0L)
                .HasColumnName("systemtagid");
        });

        modelBuilder.Entity<OcText2imageTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_text2image_tasks_pkey");

            entity.ToTable("oc_text2image_tasks");

            entity.HasIndex(e => e.Status, "t2i_tasks_status");

            entity.HasIndex(e => new { e.UserId, e.AppId, e.Identifier }, "t2i_tasks_uid_appid_ident");

            entity.HasIndex(e => e.LastUpdated, "t2i_tasks_updated");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppId)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("app_id");
            entity.Property(e => e.CompletionExpectedAt)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("completion_expected_at");
            entity.Property(e => e.Identifier)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("identifier");
            entity.Property(e => e.Input).HasColumnName("input");
            entity.Property(e => e.LastUpdated)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("last_updated");
            entity.Property(e => e.NumberOfImages)
                .HasDefaultValue(1)
                .HasColumnName("number_of_images");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcTextDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_text_documents_pkey");

            entity.ToTable("oc_text_documents");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BaseVersionEtag)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("base_version_etag");
            entity.Property(e => e.CurrentVersion)
                .HasDefaultValue(0L)
                .HasColumnName("current_version");
            entity.Property(e => e.LastSavedVersion)
                .HasDefaultValue(0L)
                .HasColumnName("last_saved_version");
            entity.Property(e => e.LastSavedVersionEtag)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("last_saved_version_etag");
            entity.Property(e => e.LastSavedVersionTime).HasColumnName("last_saved_version_time");
        });

        modelBuilder.Entity<OcTextSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_text_sessions_pkey");

            entity.ToTable("oc_text_sessions");

            entity.HasIndex(e => e.Token, "rd_session_token_idx");

            entity.HasIndex(e => new { e.DocumentId, e.LastContact }, "ts_docid_lastcontact");

            entity.HasIndex(e => e.LastContact, "ts_lastcontact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(7)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("color");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.GuestName)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("guest_name");
            entity.Property(e => e.LastAwarenessMessage)
                .HasDefaultValueSql("''::text")
                .HasColumnName("last_awareness_message");
            entity.Property(e => e.LastContact).HasColumnName("last_contact");
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .HasColumnName("token");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcTextStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_text_steps_pkey");

            entity.ToTable("oc_text_steps");

            entity.HasIndex(e => e.DocumentId, "rd_steps_did_idx");

            entity.HasIndex(e => e.Version, "rd_steps_version_idx");

            entity.HasIndex(e => e.SessionId, "textstep_session");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.Version)
                .HasDefaultValue(0L)
                .HasColumnName("version");
        });

        modelBuilder.Entity<OcTextprocessingTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_textprocessing_tasks_pkey");

            entity.ToTable("oc_textprocessing_tasks");

            entity.HasIndex(e => new { e.Status, e.Type }, "tp_tasks_status_type_nonunique");

            entity.HasIndex(e => new { e.UserId, e.AppId, e.Identifier }, "tp_tasks_uid_appid_ident");

            entity.HasIndex(e => e.LastUpdated, "tp_tasks_updated");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppId)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("app_id");
            entity.Property(e => e.CompletionExpectedAt)
                .HasDefaultValueSql("NULL::timestamp without time zone")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("completion_expected_at");
            entity.Property(e => e.Identifier)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("identifier");
            entity.Property(e => e.Input).HasColumnName("input");
            entity.Property(e => e.LastUpdated)
                .HasDefaultValue(0)
                .HasColumnName("last_updated");
            entity.Property(e => e.Output).HasColumnName("output");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcTrustedServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_trusted_servers_pkey");

            entity.ToTable("oc_trusted_servers");

            entity.HasIndex(e => e.UrlHash, "url_hash").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SharedSecret)
                .HasMaxLength(256)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("shared_secret");
            entity.Property(e => e.Status)
                .HasDefaultValue(2)
                .HasColumnName("status");
            entity.Property(e => e.SyncToken)
                .HasMaxLength(512)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("sync_token");
            entity.Property(e => e.Token)
                .HasMaxLength(128)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("token");
            entity.Property(e => e.Url)
                .HasMaxLength(512)
                .HasColumnName("url");
            entity.Property(e => e.UrlHash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("url_hash");
        });

        modelBuilder.Entity<OcTwofactorBackupcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_twofactor_backupcodes_pkey");

            entity.ToTable("oc_twofactor_backupcodes");

            entity.HasIndex(e => e.UserId, "twofactor_backupcodes_uid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(128)
                .HasColumnName("code");
            entity.Property(e => e.Used)
                .HasDefaultValue((short)0)
                .HasColumnName("used");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcTwofactorProvider>(entity =>
        {
            entity.HasKey(e => new { e.ProviderId, e.Uid }).HasName("oc_twofactor_providers_pkey");

            entity.ToTable("oc_twofactor_providers");

            entity.HasIndex(e => e.Uid, "twofactor_providers_uid");

            entity.Property(e => e.ProviderId)
                .HasMaxLength(32)
                .HasColumnName("provider_id");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasColumnName("uid");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
        });

        modelBuilder.Entity<OcUser>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("oc_users_pkey");

            entity.ToTable("oc_users");

            entity.HasIndex(e => e.UidLower, "user_uid_lower");

            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid");
            entity.Property(e => e.Displayname)
                .HasMaxLength(64)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("displayname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("password");
            entity.Property(e => e.UidLower)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid_lower");
        });

        modelBuilder.Entity<OcUserStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_user_status_pkey");

            entity.ToTable("oc_user_status");

            entity.HasIndex(e => e.ClearAt, "user_status_clr_ix");

            entity.HasIndex(e => new { e.IsUserDefined, e.Status }, "user_status_iud_ix");

            entity.HasIndex(e => e.StatusMessageTimestamp, "user_status_mtstmp_ix");

            entity.HasIndex(e => e.StatusTimestamp, "user_status_tstmp_ix");

            entity.HasIndex(e => e.UserId, "user_status_uid_ix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClearAt).HasColumnName("clear_at");
            entity.Property(e => e.CustomIcon)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("custom_icon");
            entity.Property(e => e.CustomMessage).HasColumnName("custom_message");
            entity.Property(e => e.IsBackup)
                .HasDefaultValue(false)
                .HasColumnName("is_backup");
            entity.Property(e => e.IsUserDefined).HasColumnName("is_user_defined");
            entity.Property(e => e.MessageId)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("message_id");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.StatusMessageTimestamp)
                .HasDefaultValue(0)
                .HasColumnName("status_message_timestamp");
            entity.Property(e => e.StatusTimestamp).HasColumnName("status_timestamp");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<OcUserTransferOwner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_user_transfer_owner_pkey");

            entity.ToTable("oc_user_transfer_owner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.NodeName)
                .HasMaxLength(255)
                .HasColumnName("node_name");
            entity.Property(e => e.SourceUser)
                .HasMaxLength(64)
                .HasColumnName("source_user");
            entity.Property(e => e.TargetUser)
                .HasMaxLength(64)
                .HasColumnName("target_user");
        });

        modelBuilder.Entity<OcVcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_vcategory_pkey");

            entity.ToTable("oc_vcategory");

            entity.HasIndex(e => e.Category, "category_index");

            entity.HasIndex(e => e.Type, "type_index");

            entity.HasIndex(e => e.Uid, "uid_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("category");
            entity.Property(e => e.Type)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcVcategoryToObject>(entity =>
        {
            entity.HasKey(e => new { e.Categoryid, e.Objid, e.Type }).HasName("oc_vcategory_to_object_pkey");

            entity.ToTable("oc_vcategory_to_object");

            entity.HasIndex(e => new { e.Objid, e.Type }, "vcategory_objectd_index");

            entity.Property(e => e.Categoryid)
                .HasDefaultValue(0L)
                .HasColumnName("categoryid");
            entity.Property(e => e.Objid)
                .HasDefaultValue(0L)
                .HasColumnName("objid");
            entity.Property(e => e.Type)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type");
        });

        modelBuilder.Entity<OcWebauthn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_webauthn_pkey");

            entity.ToTable("oc_webauthn");

            entity.HasIndex(e => e.PublicKeyCredentialId, "webauthn_publickeycredentialid");

            entity.HasIndex(e => e.Uid, "webauthn_uid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.PublicKeyCredentialId)
                .HasMaxLength(255)
                .HasColumnName("public_key_credential_id");
            entity.Property(e => e.Uid)
                .HasMaxLength(64)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<OcWhatsNew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oc_whats_new_pkey");

            entity.ToTable("oc_whats_new");

            entity.HasIndex(e => e.Version, "version").IsUnique();

            entity.HasIndex(e => new { e.Version, e.Etag }, "version_etag_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("''::text")
                .HasColumnName("data");
            entity.Property(e => e.Etag)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("etag");
            entity.Property(e => e.LastCheck)
                .HasDefaultValue(0)
                .HasColumnName("last_check");
            entity.Property(e => e.Version)
                .HasMaxLength(64)
                .HasDefaultValueSql("'11'::character varying")
                .HasColumnName("version");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

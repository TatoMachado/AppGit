using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGit.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    login = table.Column<string>(type: "TEXT", nullable: true),
                    node_id = table.Column<string>(type: "TEXT", nullable: true),
                    avatar_url = table.Column<string>(type: "TEXT", nullable: true),
                    gravatar_id = table.Column<string>(type: "TEXT", nullable: true),
                    url = table.Column<string>(type: "TEXT", nullable: true),
                    html_url = table.Column<string>(type: "TEXT", nullable: true),
                    followers_url = table.Column<string>(type: "TEXT", nullable: true),
                    following_url = table.Column<string>(type: "TEXT", nullable: true),
                    gists_url = table.Column<string>(type: "TEXT", nullable: true),
                    starred_url = table.Column<string>(type: "TEXT", nullable: true),
                    subscriptions_url = table.Column<string>(type: "TEXT", nullable: true),
                    organizations_url = table.Column<string>(type: "TEXT", nullable: true),
                    repos_url = table.Column<string>(type: "TEXT", nullable: true),
                    events_url = table.Column<string>(type: "TEXT", nullable: true),
                    received_events_url = table.Column<string>(type: "TEXT", nullable: true),
                    type = table.Column<string>(type: "TEXT", nullable: true),
                    site_admin = table.Column<string>(type: "TEXT", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    company = table.Column<string>(type: "TEXT", nullable: true),
                    blog = table.Column<string>(type: "TEXT", nullable: true),
                    location = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    hireable = table.Column<string>(type: "TEXT", nullable: true),
                    twitter_username = table.Column<string>(type: "TEXT", nullable: true),
                    public_repos = table.Column<int>(type: "INTEGER", nullable: false),
                    public_gists = table.Column<int>(type: "INTEGER", nullable: false),
                    followers = table.Column<int>(type: "INTEGER", nullable: false),
                    following = table.Column<int>(type: "INTEGER", nullable: false),
                    created_at = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Repo",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    node_id = table.Column<string>(type: "TEXT", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    full_name = table.Column<string>(type: "TEXT", nullable: true),
                    repoprivate = table.Column<string>(type: "TEXT", nullable: true),
                    ownerid = table.Column<int>(type: "INTEGER", nullable: true),
                    html_url = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    fork = table.Column<string>(type: "TEXT", nullable: true),
                    url = table.Column<string>(type: "TEXT", nullable: true),
                    forks_url = table.Column<string>(type: "TEXT", nullable: true),
                    keys_url = table.Column<string>(type: "TEXT", nullable: true),
                    collaborators_url = table.Column<string>(type: "TEXT", nullable: true),
                    teams_url = table.Column<string>(type: "TEXT", nullable: true),
                    hooks_url = table.Column<string>(type: "TEXT", nullable: true),
                    issue_events_url = table.Column<string>(type: "TEXT", nullable: true),
                    events_url = table.Column<string>(type: "TEXT", nullable: true),
                    assignees_url = table.Column<string>(type: "TEXT", nullable: true),
                    branches_url = table.Column<string>(type: "TEXT", nullable: true),
                    tags_url = table.Column<string>(type: "TEXT", nullable: true),
                    blobs_url = table.Column<string>(type: "TEXT", nullable: true),
                    git_tags_url = table.Column<string>(type: "TEXT", nullable: true),
                    git_refs_url = table.Column<string>(type: "TEXT", nullable: true),
                    trees_url = table.Column<string>(type: "TEXT", nullable: true),
                    statuses_url = table.Column<string>(type: "TEXT", nullable: true),
                    languages_url = table.Column<string>(type: "TEXT", nullable: true),
                    stargazers_url = table.Column<string>(type: "TEXT", nullable: true),
                    contributors_url = table.Column<string>(type: "TEXT", nullable: true),
                    subscribers_url = table.Column<string>(type: "TEXT", nullable: true),
                    subscription_url = table.Column<string>(type: "TEXT", nullable: true),
                    commits_url = table.Column<string>(type: "TEXT", nullable: true),
                    git_commits_url = table.Column<string>(type: "TEXT", nullable: true),
                    comments_url = table.Column<string>(type: "TEXT", nullable: true),
                    issue_comment_url = table.Column<string>(type: "TEXT", nullable: true),
                    contents_url = table.Column<string>(type: "TEXT", nullable: true),
                    compare_url = table.Column<string>(type: "TEXT", nullable: true),
                    merges_url = table.Column<string>(type: "TEXT", nullable: true),
                    archive_url = table.Column<string>(type: "TEXT", nullable: true),
                    downloads_url = table.Column<string>(type: "TEXT", nullable: true),
                    issues_url = table.Column<string>(type: "TEXT", nullable: true),
                    pulls_url = table.Column<string>(type: "TEXT", nullable: true),
                    milestones_url = table.Column<string>(type: "TEXT", nullable: true),
                    notifications_url = table.Column<string>(type: "TEXT", nullable: true),
                    labels_url = table.Column<string>(type: "TEXT", nullable: true),
                    releases_url = table.Column<string>(type: "TEXT", nullable: true),
                    deployments_url = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true),
                    pushed_at = table.Column<string>(type: "TEXT", nullable: true),
                    git_url = table.Column<string>(type: "TEXT", nullable: true),
                    ssh_url = table.Column<string>(type: "TEXT", nullable: true),
                    clone_url = table.Column<string>(type: "TEXT", nullable: true),
                    svn_url = table.Column<string>(type: "TEXT", nullable: true),
                    homepage = table.Column<string>(type: "TEXT", nullable: true),
                    size = table.Column<int>(type: "INTEGER", nullable: false),
                    stargazers_count = table.Column<int>(type: "INTEGER", nullable: false),
                    watchers_count = table.Column<int>(type: "INTEGER", nullable: false),
                    language = table.Column<string>(type: "TEXT", nullable: true),
                    has_issues = table.Column<bool>(type: "INTEGER", nullable: false),
                    has_projects = table.Column<bool>(type: "INTEGER", nullable: false),
                    has_downloads = table.Column<bool>(type: "INTEGER", nullable: false),
                    has_wiki = table.Column<bool>(type: "INTEGER", nullable: false),
                    has_pages = table.Column<bool>(type: "INTEGER", nullable: false),
                    forks_count = table.Column<int>(type: "INTEGER", nullable: false),
                    mirror_url = table.Column<string>(type: "TEXT", nullable: true),
                    archived = table.Column<bool>(type: "INTEGER", nullable: false),
                    disabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    open_issues_count = table.Column<int>(type: "INTEGER", nullable: false),
                    license = table.Column<string>(type: "TEXT", nullable: true),
                    allow_forking = table.Column<bool>(type: "INTEGER", nullable: false),
                    is_template = table.Column<bool>(type: "INTEGER", nullable: false),
                    topics = table.Column<string>(type: "TEXT", nullable: true),
                    visibility = table.Column<string>(type: "TEXT", nullable: true),
                    forks = table.Column<int>(type: "INTEGER", nullable: false),
                    open_issues = table.Column<int>(type: "INTEGER", nullable: false),
                    watchers = table.Column<int>(type: "INTEGER", nullable: false),
                    default_branch = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Repo_User_ownerid",
                        column: x => x.ownerid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repo_ownerid",
                table: "Repo",
                column: "ownerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repo");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

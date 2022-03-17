﻿// <auto-generated />
using System;
using AppGit.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppGit.Migrations
{
    [DbContext(typeof(RepoContext))]
    [Migration("20220315123941_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("AppGit.Models.Repo", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("allow_forking")
                        .HasColumnType("INTEGER");

                    b.Property<string>("archive_url")
                        .HasColumnType("TEXT");

                    b.Property<bool>("archived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("assignees_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("blobs_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("branches_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("clone_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("collaborators_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("comments_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("commits_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("compare_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("contents_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("contributors_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("default_branch")
                        .HasColumnType("TEXT");

                    b.Property<string>("deployments_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("disabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("downloads_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("events_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("fork")
                        .HasColumnType("TEXT");

                    b.Property<int>("forks")
                        .HasColumnType("INTEGER");

                    b.Property<int>("forks_count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("forks_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("full_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("git_commits_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("git_refs_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("git_tags_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("git_url")
                        .HasColumnType("TEXT");

                    b.Property<bool>("has_downloads")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("has_issues")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("has_pages")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("has_projects")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("has_wiki")
                        .HasColumnType("INTEGER");

                    b.Property<string>("homepage")
                        .HasColumnType("TEXT");

                    b.Property<string>("hooks_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("html_url")
                        .HasColumnType("TEXT");

                    b.Property<bool>("is_template")
                        .HasColumnType("INTEGER");

                    b.Property<string>("issue_comment_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("issue_events_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("issues_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("keys_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("labels_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("language")
                        .HasColumnType("TEXT");

                    b.Property<string>("languages_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("license")
                        .HasColumnType("TEXT");

                    b.Property<string>("merges_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("milestones_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("mirror_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("node_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("notifications_url")
                        .HasColumnType("TEXT");

                    b.Property<int>("open_issues")
                        .HasColumnType("INTEGER");

                    b.Property<int>("open_issues_count")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ownerid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("pulls_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("pushed_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("releases_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("repoprivate")
                        .HasColumnType("TEXT");

                    b.Property<int>("size")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ssh_url")
                        .HasColumnType("TEXT");

                    b.Property<int>("stargazers_count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("stargazers_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("statuses_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("subscribers_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("subscription_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("svn_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("tags_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("teams_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("topics")
                        .HasColumnType("TEXT");

                    b.Property<string>("trees_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("updated_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .HasColumnType("TEXT");

                    b.Property<string>("visibility")
                        .HasColumnType("TEXT");

                    b.Property<int>("watchers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("watchers_count")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("ownerid");

                    b.ToTable("Repo");
                });

            modelBuilder.Entity("AppGit.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("avatar_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("blog")
                        .HasColumnType("TEXT");

                    b.Property<string>("company")
                        .HasColumnType("TEXT");

                    b.Property<string>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("events_url")
                        .HasColumnType("TEXT");

                    b.Property<int>("followers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("followers_url")
                        .HasColumnType("TEXT");

                    b.Property<int>("following")
                        .HasColumnType("INTEGER");

                    b.Property<string>("following_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("gists_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("gravatar_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("hireable")
                        .HasColumnType("TEXT");

                    b.Property<string>("html_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("location")
                        .HasColumnType("TEXT");

                    b.Property<string>("login")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("node_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("organizations_url")
                        .HasColumnType("TEXT");

                    b.Property<int>("public_gists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("public_repos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("received_events_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("repos_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("site_admin")
                        .HasColumnType("TEXT");

                    b.Property<string>("starred_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("subscriptions_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("twitter_username")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.Property<string>("updated_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AppGit.Models.Repo", b =>
                {
                    b.HasOne("AppGit.Models.User", "owner")
                        .WithMany("Repo")
                        .HasForeignKey("ownerid");

                    b.Navigation("owner");
                });

            modelBuilder.Entity("AppGit.Models.User", b =>
                {
                    b.Navigation("Repo");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApi
{

    public class JSON
    {
        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string name_with_namespace { get; set; }
        public string path { get; set; }
        public string path_with_namespace { get; set; }
        public DateTime created_at { get; set; }
        public string default_branch { get; set; }
        public List<object> tag_list { get; set; }
        public List<object> topics { get; set; }
        public string ssh_url_to_repo { get; set; }
        public string http_url_to_repo { get; set; }
        public string web_url { get; set; }
        public string readme_url { get; set; }
        public object avatar_url { get; set; }
        public int forks_count { get; set; }
        public int star_count { get; set; }
        public DateTime last_activity_at { get; set; }
        public Namespace @namespace { get; set; }
        public string container_registry_image_prefix { get; set; }
        public Links _links { get; set; }
        public bool packages_enabled { get; set; }
        public bool empty_repo { get; set; }
        public bool archived { get; set; }
        public string visibility { get; set; }
        public Owner owner { get; set; }
        public bool resolve_outdated_diff_discussions { get; set; }
        public ContainerExpirationPolicy container_expiration_policy { get; set; }
        public bool issues_enabled { get; set; }
        public bool merge_requests_enabled { get; set; }
        public bool wiki_enabled { get; set; }
        public bool jobs_enabled { get; set; }
        public bool snippets_enabled { get; set; }
        public bool container_registry_enabled { get; set; }
        public bool service_desk_enabled { get; set; }
        public string service_desk_address { get; set; }
        public bool can_create_merge_request_in { get; set; }
        public string issues_access_level { get; set; }
        public string repository_access_level { get; set; }
        public string merge_requests_access_level { get; set; }
        public string forking_access_level { get; set; }
        public string wiki_access_level { get; set; }
        public string builds_access_level { get; set; }
        public string snippets_access_level { get; set; }
        public string pages_access_level { get; set; }
        public string operations_access_level { get; set; }
        public string analytics_access_level { get; set; }
        public string container_registry_access_level { get; set; }
        public object emails_disabled { get; set; }
        public bool shared_runners_enabled { get; set; }
        public bool lfs_enabled { get; set; }
        public int creator_id { get; set; }
        public string import_status { get; set; }
        public int open_issues_count { get; set; }
        public int ci_default_git_depth { get; set; }
        public bool ci_forward_deployment_enabled { get; set; }
        public bool ci_job_token_scope_enabled { get; set; }
        public bool public_jobs { get; set; }
        public int build_timeout { get; set; }
        public string auto_cancel_pending_pipelines { get; set; }
        public object build_coverage_regex { get; set; }
        public string ci_config_path { get; set; }
        public List<object> shared_with_groups { get; set; }
        public bool only_allow_merge_if_pipeline_succeeds { get; set; }
        public object allow_merge_on_skipped_pipeline { get; set; }
        public bool restrict_user_defined_variables { get; set; }
        public bool request_access_enabled { get; set; }
        public bool only_allow_merge_if_all_discussions_are_resolved { get; set; }
        public bool remove_source_branch_after_merge { get; set; }
        public bool printing_merge_request_link_enabled { get; set; }
        public string merge_method { get; set; }
        public string squash_option { get; set; }
        public object suggestion_commit_message { get; set; }
        public object merge_commit_template { get; set; }
        public object squash_commit_template { get; set; }
        public bool auto_devops_enabled { get; set; }
        public string auto_devops_deploy_strategy { get; set; }
        public bool autoclose_referenced_issues { get; set; }
        public bool keep_latest_artifact { get; set; }
        public object runner_token_expiration_interval { get; set; }
        public int approvals_before_merge { get; set; }
        public bool mirror { get; set; }
        public string external_authorization_classification_label { get; set; }
        public object marked_for_deletion_at { get; set; }
        public object marked_for_deletion_on { get; set; }
        public bool requirements_enabled { get; set; }
        public bool security_and_compliance_enabled { get; set; }
        public List<object> compliance_frameworks { get; set; }
        public object issues_template { get; set; }
        public object merge_requests_template { get; set; }
        public bool merge_pipelines_enabled { get; set; }
        public bool merge_trains_enabled { get; set; }
        public Permissions permissions { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Namespace
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string kind { get; set; }
        public string full_path { get; set; }
        public object parent_id { get; set; }
        public string avatar_url { get; set; }
        public string web_url { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
        public string issues { get; set; }
        public string merge_requests { get; set; }
        public string repo_branches { get; set; }
        public string labels { get; set; }
        public string events { get; set; }
        public string members { get; set; }
    }

    public class Owner
    {
        public int id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string avatar_url { get; set; }
        public string web_url { get; set; }
    }

    public class ContainerExpirationPolicy
    {
        public string cadence { get; set; }
        public bool enabled { get; set; }
        public int keep_n { get; set; }
        public string older_than { get; set; }
        public string name_regex { get; set; }
        public object name_regex_keep { get; set; }
        public DateTime next_run_at { get; set; }
    }

    public class ProjectAccess
    {
        public int access_level { get; set; }
        public int notification_level { get; set; }
    }

    public class Permissions
    {
        public ProjectAccess project_access { get; set; }
        public object group_access { get; set; }
    }

    public class Group
    {
        public int id { get; set; }
        public string web_url { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string description { get; set; }
        public string visibility { get; set; }
        public bool share_with_group_lock { get; set; }
        public bool require_two_factor_authentication { get; set; }
        public int two_factor_grace_period { get; set; }
        public string project_creation_level { get; set; }
        public object auto_devops_enabled { get; set; }
        public string subgroup_creation_level { get; set; }
        public object emails_disabled { get; set; }
        public object mentions_disabled { get; set; }
        public bool lfs_enabled { get; set; }
        public int default_branch_protection { get; set; }
        public object avatar_url { get; set; }
        public bool request_access_enabled { get; set; }
        public string full_name { get; set; }
        public string full_path { get; set; }
        public DateTime created_at { get; set; }
        public object parent_id { get; set; }
        public object ldap_cn { get; set; }
        public object ldap_access { get; set; }
    }
}

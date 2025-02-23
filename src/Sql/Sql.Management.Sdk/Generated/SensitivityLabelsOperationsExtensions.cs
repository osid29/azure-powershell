// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SensitivityLabelsOperations
    /// </summary>
    public static partial class SensitivityLabelsOperationsExtensions
    {
        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='skipToken'>
        /// 
        /// </param>
        /// <param name='count'>
        /// 
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SensitivityLabel> ListCurrentByDatabase(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel>), string skipToken = default(string), bool? count = default(bool?))
        {
                return ((ISensitivityLabelsOperations)operations).ListCurrentByDatabaseAsync(resourceGroupName, serverName, databaseName, odataQuery, skipToken, count).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='skipToken'>
        /// 
        /// </param>
        /// <param name='count'>
        /// 
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SensitivityLabel>> ListCurrentByDatabaseAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel>), string skipToken = default(string), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListCurrentByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, odataQuery, skipToken, count, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Update sensitivity labels of a given database using an operations batch.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static void Update(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, SensitivityLabelUpdateList parameters)
        {
                ((ISensitivityLabelsOperations)operations).UpdateAsync(resourceGroupName, serverName, databaseName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update sensitivity labels of a given database using an operations batch.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task UpdateAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, SensitivityLabelUpdateList parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='skipToken'>
        /// 
        /// </param>
        /// <param name='includeDisabledRecommendations'>
        /// Specifies whether to include disabled recommendations or not.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SensitivityLabel> ListRecommendedByDatabase(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel>), string skipToken = default(string), bool? includeDisabledRecommendations = default(bool?))
        {
                return ((ISensitivityLabelsOperations)operations).ListRecommendedByDatabaseAsync(resourceGroupName, serverName, databaseName, odataQuery, skipToken, includeDisabledRecommendations).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='skipToken'>
        /// 
        /// </param>
        /// <param name='includeDisabledRecommendations'>
        /// Specifies whether to include disabled recommendations or not.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SensitivityLabel>> ListRecommendedByDatabaseAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SensitivityLabel>), string skipToken = default(string), bool? includeDisabledRecommendations = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListRecommendedByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, odataQuery, skipToken, includeDisabledRecommendations, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        public static void EnableRecommendation(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
        {
                ((ISensitivityLabelsOperations)operations).EnableRecommendationAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task EnableRecommendationAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.EnableRecommendationWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        public static void DisableRecommendation(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
        {
                ((ISensitivityLabelsOperations)operations).DisableRecommendationAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DisableRecommendationAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DisableRecommendationWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets the sensitivity label of a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        /// <param name='sensitivityLabelSource'>
        /// The source of the sensitivity label.
        /// </param>
        public static SensitivityLabel Get(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource)
        {
                return ((ISensitivityLabelsOperations)operations).GetAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, sensitivityLabelSource).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        /// <param name='sensitivityLabelSource'>
        /// The source of the sensitivity label.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SensitivityLabel> GetAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, sensitivityLabelSource, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or updates the sensitivity label of a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        public static SensitivityLabel CreateOrUpdate(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabel parameters)
        {
                return ((ISensitivityLabelsOperations)operations).CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates the sensitivity label of a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SensitivityLabel> CreateOrUpdateAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabel parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes the sensitivity label of a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        public static void Delete(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
        {
                ((ISensitivityLabelsOperations)operations).DeleteAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the sensitivity label of a given column
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='columnName'>
        /// The name of the column.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SensitivityLabel> ListCurrentByDatabaseNext(this ISensitivityLabelsOperations operations, string nextPageLink)
        {
                return ((ISensitivityLabelsOperations)operations).ListCurrentByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SensitivityLabel>> ListCurrentByDatabaseNextAsync(this ISensitivityLabelsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListCurrentByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SensitivityLabel> ListRecommendedByDatabaseNext(this ISensitivityLabelsOperations operations, string nextPageLink)
        {
                return ((ISensitivityLabelsOperations)operations).ListRecommendedByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the sensitivity labels of a given database
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SensitivityLabel>> ListRecommendedByDatabaseNextAsync(this ISensitivityLabelsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListRecommendedByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}

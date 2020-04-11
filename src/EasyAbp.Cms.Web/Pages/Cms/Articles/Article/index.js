$(function () {

    var l = abp.localization.getResource('Cms');

    var service = easyAbp.cms.articles.article;
    var createModal = new abp.ModalManager(abp.appPath + 'Cms/Articles/Article/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Cms/Articles/Article/EditModal');

    var dataTable = $('#ArticleTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('ArticleDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "tenantId" },
            { data: "title" },
            { data: "content" },
            { data: "readCount" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewArticleButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
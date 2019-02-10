(function () {

    $(function () {
        var _personService = abp.services.app.person;

        var _$modal = $("#PersonCreateModal");
        var _$form = _$modal.find('form');

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (!_$form.valid()) {
                return;
            }

            var personEditDto = _$form.serializeFormToObject();

            abp.ui.setBusy(_$modal);
            _personService.createOrUpdatePerson({
                personEditDto
            }).done(function () {
                _$modal.modal('hide');
                refreshButton();
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });
        //end add

        $("#RefreshButton").click(function () {
            refreshButton();
        });

        function refreshButton() {
            location.reload();
        }


        $('.delete-person').click(function () {
            var personid = $(this).attr("data-person-id");
            var personName = $(this).attr("data-person-name");
            deletePerson(personid, personName);

        });

        function deletePerson(id, name) {
            abp.message.confirm("是否确认删除 " + name + "?", function(isConfirmed){
                if(isConfirmed){
                    _personService.deletePerson({id}).done(function(){
                        refreshButton();
                    });
                }
            });
            
        }

        //edit
        $('.edit-person').click(function (e) {
            e.preventDefault();
            var personId = $(this).attr("data-person-id");
            _personService.getPersonForEdit({id:personId}).done(function(data){
                $("input[name=Id]").val(data.person.id);
                $("input[name=Name]").val(data.person.name).parent().addClass('focused');
                $("input[name=Email]").val(data.person.email).parent().addClass('focused');
                $("input[name=Address]").val(data.person.address).parent().addClass('focused');
            });
        });
        $("#PersonCreateModal").on("hide.bs.modal", function(){
            _$form[0].reset();            
        });
    });


})();
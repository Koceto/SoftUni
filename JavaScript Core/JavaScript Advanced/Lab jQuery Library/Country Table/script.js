function initializeTable() {
    addCountryToTable('Bulgaria', 'Sofia');
    addCountryToTable('Germany', 'Berlin');
    addCountryToTable('Russia', 'Moscow');
    fixRowLinks();

    $('#createLink').click(createCountry);

    function addCountryToTable(country, capital) {
        let tr = $('<tr>')
            .append($('<td>').text(country))
            .append($('<td>').text(capital))
            .append($('<td>')
                .append($('<a href="#" id="upLink">[Up]</a>').click(moveRowUp)).append(' ')
                .append($('<a href="#" id="downLink">[Down]</a>').click(moveRowDown)).append(' ')
                .append($('<a href="#">[Delete]</a>').click(deleteRow)));

        $('#countriesTable').append(tr).click(fixRowLinks);
    }

    function createCountry() {
        let country = $('#newCountryText');
        let capital = $('#newCapitalText');

        addCountryToTable(country.val(), capital.val());

        country.val('');
        capital.val('');
    }

    function moveRowUp() {
        let tr = $(this).parent().parent();

        if (tr.index() > 2) {
            tr.insertBefore(tr.prev());
        }
    }

    function moveRowDown() {
        let tr = $(this).parent().parent();
        if (!tr.is(':last-child')) {
            tr.insertAfter(tr.next());
        }
    }

    function deleteRow() {
        $(this).parent().parent().remove();
    }

    function fixRowLinks() {
        let elements = $('#countriesTable').find('tr');

        for (const element of elements) {
            if ($(element).index() == 2) {
                $(element).find('#upLink').css('display', 'none');
            } else {
                $(element).find('#upLink').css('display', 'inline');
            }

            if ($(element).index() == elements.toArray().length - 1) {
                $(element).find('#downLink').css('display', 'none');
            } else {
                $(element).find('#downLink').css('display', 'inline');
            }
        }
    }
}
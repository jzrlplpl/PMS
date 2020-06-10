var inspectors = new Bloodhound({
    datumTokenizer: Bloodhound.tokenizers.obj.whitespace('name'),
    queryTokenizer: Bloodhound.tokenizers.whitespace,
    prefetch: {
        url: '/api/inspectors',
    }
});

inspectors.initialize();

$('#Inspector').tagsinput({
    itemValue: 'Name',
    typeaheadjs: [{
        minlength: 1,
        highlight: true,
    }, {
        minlength: 1,
        name: 'inspectors',
        displayKey: 'Name',
        valueKey: 'Name',
        source: inspectors.ttAdapter()
        }],
    freeInput: true
});

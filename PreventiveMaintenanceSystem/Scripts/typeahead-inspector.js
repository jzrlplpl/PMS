var inspectors = new Bloodhound({
    datumTokenizer: Bloodhound.tokenizers.obj.whitespace("Name"),
    queryTokenizer: Bloodhound.tokenizers.whitespace,
    prefetch: {
        url: '/api/inspectors'
    }
});
inspectors.clearPrefetchCache();
inspectors.initialize(true);

$('#Inspector').tagsinput({
    itemValue: 'Name',
    typeaheadjs: [{
        minlength: 1,
        highlight: true,
    }, {
        name: 'inspectors',
        displayKey: 'Name',
        valueKey: 'Name',
        cache: false,
        source: inspectors.ttAdapter()
        }],
    freeInput: true
});

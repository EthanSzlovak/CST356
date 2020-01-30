var staff = '{"staff": [\
    {"First": "First Name", "Middle": "Middle Initial", "Last":"Last Name"},\
    {"First": "James", "Middle": "O", "Last":"Shaugnessy"},\
    {"First": "Idward", "Middle": "P", "Last":"Freely"},\
    {"First": "Hugh", "Middle": "J", "Last":"Nus"},\
    {"First": "Patrick", "Middle": "D", "Last":"Basedman"}]}'


function returnStaff(){
    return JSON.parse(staff);
}

function displayStaff(input) {
    var tableList = "";
    for(i = 0; i < input.length; i++) {
        var first = input[i].First;
        var second = input[i].Middle;
        var third = input[i].Last;
        tableList += "<tr><td>" + first + "</td><td>" + second + "</td><td>" + third + "</td>";
        document.getElementById("staff-list").innerHTML = tableList;
    }
}


function populateStaff(){
    var data = returnStaff();
    displayStaff(data.staff);
}

<template>
  <div class="students">
    <a></a>
    <h1>Student Page</h1>
    <h3>Student Data</h3>
    <table id='studentTable'>  
            <thead>
                <tr>
                    <th class="border">Student ID Number</th>
                    <th class="border">Email Address</th>
                </tr>
            </thead>       
            <tbody>
                <tr v-for="student in students" v-bind:key="student.student_id">
                    <td class="border">{{ student.student_id }}</td>
                    <td class="border">{{ student.email_address }}</td>                
                </tr>
            </tbody>
        </table>
  </div>
</template>

<script>
import Vue from 'vue';
export default {
    name: 'Students',
        
        data () {
            return {
                students: [],
                operation: 'list',
                student_id: undefined,
                email_address: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },
        methods: {
            getStudents: function() {
                let url = `https://localhost:44331/api/student`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
    },

    mounted() {
        this.students = this.getStudents();
        this.operation = 'list';
    }
}
  
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.datatable {
    width: 50%;
    padding: 6px;
    border-collapse: collapse;
}

th {
    text-align: center;
    padding: 10px;
}
td {
    text-align: left;
    padding: 10px;
}
h3 {
    text-align: left;
}
</style>

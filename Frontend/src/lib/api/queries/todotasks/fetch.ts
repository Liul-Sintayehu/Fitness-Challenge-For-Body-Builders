import apiClient from "@/lib/axois";

 

export const fetchTasks =  async (): Promise<any[]>  => {
  const response = await apiClient.get("/ToDoTask/GetAll");
  return response.data;
};

 
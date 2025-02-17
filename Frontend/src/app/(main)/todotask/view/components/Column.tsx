"use client";

import { ColumnDef } from "@tanstack/react-table";
import { ArrowUpDown } from "lucide-react";
import { Button } from "@/components/ui/button";
import { Badge } from "@/components/ui/badge";

export const columns: ColumnDef<any>[] = [
  {
    accessorKey: "id",
    header: ({ column }) => {
      return (
        <Button
          className="text-gray-600 text-start "
          variant="ghost"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
          style={{ textAlign: "start" }}
        >
          Name
          <ArrowUpDown className="  h-fit w-fit max-w-4" />
        </Button>
      );
    },
    cell: ({ row }) => {
      return <div className="p-2  ml-4">{row.original.id}</div>;
    },
  },
  {
    accessorKey: "name",
    header: ({ column }) => {
      return (
        <Button
          className="text-gray-600 text-start "
          variant="ghost"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
          style={{ textAlign: "start" }}
        >
          Description
          <ArrowUpDown className="  h-fit w-fit max-w-4" />
        </Button>
      );
    },
    cell: ({ row }) => {
      return <div className="p-2  ml-4">{row.original.name}</div>;
    },
  },
  {
    accessorKey: "recordStatus",
    header: ({ column }) => {
      return (
        <Button
          className="text-gray-600 w-fit   flex justify-start text-start"
          variant="ghost"
          style={{ textAlign: "start" }}
        >
          Record Status
          <ArrowUpDown className="ml-2 h-4 w-4" />
        </Button>
      );
    },
    cell: ({ row }) => {
      return (
        <div className="p-2  ml-4">
          {row.original.recordStatus == 1 ? (
            <Badge variant="destructive">Deactivated</Badge>
          ) : (
            <Badge variant="default">Active</Badge>
          )}
        </div>
      );
    },
  },
  {
    accessorKey: "Actions",
    header: ({ column }) => {
      return (
        <Button
          className="text-gray-600 text-start "
          variant="ghost"
          onClick={() => column.toggleSorting(column.getIsSorted() === "asc")}
          style={{ textAlign: "start" }}
        >
          Actions
          <ArrowUpDown className="  h-fit w-fit max-w-4" />
        </Button>
      );
    },
    cell: ({ row }) => {
      return <div className="p-2  ml-4">actions</div>;
    },
  },
];
